using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TP2_WF.Entidades;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP2_WF.Presentacion
{
    public partial class PantallaVisualizacion : Form
    {
        CsvReader csvReader;
        decimal[] MinMax;
        int CantidadIntervalos;

        public PantallaVisualizacion(decimal[] minMax, int cantIntervalos)
        {
            InitializeComponent();
            csvReader = new CsvReader();
            MinMax = minMax;
            CantidadIntervalos = cantIntervalos;
        }

        private void PantallaVisualizacion_Load(object sender, EventArgs e)
        {
            DataTable csv = new DataTable();
            int[] frecObs = new int[CantidadIntervalos];

            csvReader.LoadCsvData(csv, frecObs, MinMax);
            dataGridView1.DataSource = csv;
        }
    }
}

