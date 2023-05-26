using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP4.Entidades;

namespace TP4
{
    public partial class PantallaVisualizacion : Form
    {
        DataTable CSV;
        CSVReader csvReader;
        public PantallaVisualizacion(string _archivoCSV)
        {
            // Inicializa los componentes de la pantalla e instancia
            InitializeComponent();
            csvReader = new CSVReader(_archivoCSV);
            CSV = new DataTable();
        }
        
        private void PantallaVisualizacion_Load(object sender, EventArgs e)
        {
            //Carga la grilla con los contenidos del CSV

            // aca metodo CSV reader supongo que devuelve los 4 valores a cargar (tPromedios por cada uno, porc que retira)

            gdw_iteracionesSolicitadas.DataSource = CSV;

            // Estetico Columnas Tabla
            foreach (DataGridViewColumn columna in gdw_iteracionesSolicitadas.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Cargamos la probabilidad

            //txt_tiempoPromEsperaF.Text = 
            //txt_tiempoPromEsperaHB.Text =
            //txt_tiempoPromEsperaBB.Text =
            //txt_porcRetiraSinJugar.Text = 
            
        }
    }
}
