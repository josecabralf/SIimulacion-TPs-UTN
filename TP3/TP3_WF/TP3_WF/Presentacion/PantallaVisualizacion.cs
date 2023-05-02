using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3_WF.Entidades;

namespace TP3_WF.Presentacion
{
    public partial class PantallaVisualizacion : Form
    {
        DataTable CSV;
        CsvReader csvReader;
        public PantallaVisualizacion(string _archivoCSV)
        {
            // Inicializa los componentes de la pantalla e instancia
            InitializeComponent();
            csvReader = new CsvReader(_archivoCSV);
            CSV = new DataTable();
        }

        private void PantallaVisualizacion_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los contenidos del CSV
            double probabilidad = csvReader.LoadCsvData(CSV);
            gdw_expSolicitados.DataSource = CSV;

            // Estetico Columnas Tabla
            foreach (DataGridViewColumn columna in gdw_expSolicitados.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Cargamos la probabilidad

            txt_probabilidad.Text = probabilidad.ToString();
        }
    }
}
