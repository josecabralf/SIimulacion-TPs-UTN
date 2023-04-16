using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace TP2_WF.Presentacion
{
    public partial class PantallaVisualizacion : Form
    {
        // Ruta relativa al archivo CSV con los datos
        private string _archivoCSV = @"../../Recursos/numeros.csv";
        private List<string> datos = new List<string>();
        public PantallaVisualizacion()
        {
            InitializeComponent();
        }

        private void PantallaVisualizacion_Load(object sender, EventArgs e)
        {
            LoadCsvData();
        }

        private void LoadCsvData()
        {
            try
            {
                //Leer lineas del archivo:
                DataTable dt = new DataTable();
                dt.Columns.Add("Numeros Generados");
                string[] lines = File.ReadAllLines(_archivoCSV);
                foreach (string line in lines)
                {
                    dt.Rows.Add(line);
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al cargar datos del CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

