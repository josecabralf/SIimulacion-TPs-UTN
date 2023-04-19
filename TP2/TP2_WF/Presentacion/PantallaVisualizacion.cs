﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TP2_WF.Entidades;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.Common;

namespace TP2_WF.Presentacion
{
    public partial class PantallaVisualizacion : Form
    {
        CsvReader csvReader;
        decimal[] MinMax;
        DataTable CSV;
        int[] frecObs;

        public PantallaVisualizacion(decimal[] minMax, int cantIntervalos)
        {
            // Inicializa los componentes de la pantalla e instancia
            InitializeComponent();

            csvReader = new CsvReader();
            MinMax = minMax;
            CSV = new DataTable();
            frecObs = new int[cantIntervalos];
        }

        private void PantallaVisualizacion_Load(object sender, EventArgs e)
        {
            // Para el eje x:
            decimal[] arrayLimSup = new decimal[frecObs.Length];

            //Obtiene el ancho de intervalo
            decimal anchoIntervalo = (MinMax[1] - MinMax[0]) / frecObs.Length;
            anchoIntervalo = Math.Truncate(anchoIntervalo * 10000) / 10000;

            // Se carga el visualizador de datos y las frecuencias observadas
            csvReader.LoadCsvData(CSV, frecObs, MinMax, arrayLimSup);
            gdw_dataSet.DataSource = CSV;

            // Estetico Columnas Tabla
            foreach (DataGridViewColumn columna in gdw_dataSet.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Establecemos el título del gráfico
            chart1.Titles.Add("Gráfico de Frecuencias Observadas");

            // Le agreagamos un area al grafico
            ChartArea chartArea1 = new ChartArea();
            chartArea1.InnerPlotPosition.Auto = true;
            chart1.ChartAreas.Add(chartArea1);

            // Se establece la serie para que se vea como histograma
            Series frecObsSerie = new Series();
            frecObsSerie.ChartType = SeriesChartType.Column;
            frecObsSerie.Name = "Frecuencias Observadas";
            chart1.Series.Add(frecObsSerie);
            frecObsSerie.IsVisibleInLegend = false;

            // Se agregan las frecObs al grafico
            for (int i = 0; i < arrayLimSup.Length; i++)
            {
                string intervalo = $"[{arrayLimSup[i] - anchoIntervalo},{arrayLimSup[i]})";
                DataPoint dp = new DataPoint();
                dp.AxisLabel = intervalo;
                dp.YValues = new double[] { frecObs[i] };
                frecObsSerie.Points.Add(dp);

            };

            // Configurar etiquetas del eje X
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Title = "Intervalos";

            // Configurar etiquetas del eje Y
            chart1.ChartAreas[0].AxisY.Title = "Frecuencias Observadas";

            // Se genera la tabla de frecObs
            this.cargarTablaFrecObs(arrayLimSup, anchoIntervalo);
        }

        private void cargarTablaFrecObs(decimal[] arrayLimSup, decimal anchoIntervalo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Intervalo");
            dt.Columns.Add("Frecuencia Observada");

            // Agrega los numeros a la tabla y obtiene la frecuencia observada de los intervalos
            decimal limInf;

            for (int i = 0; i< arrayLimSup.Length;i++)
            {
                limInf = arrayLimSup[i] - anchoIntervalo;
                string intervalo = $"{limInf} <= x < {arrayLimSup[i]}";
                dt.Rows.Add(intervalo, frecObs[i]);
            };

            gdw_frecObs.DataSource = dt;
            foreach (DataGridViewColumn columna in gdw_frecObs.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}

