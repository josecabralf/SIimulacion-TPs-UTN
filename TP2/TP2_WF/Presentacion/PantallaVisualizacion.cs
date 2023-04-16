using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // ACA SERIA SI TUVIERAMOS QUE LISTAR SOLO UN RANGO

            // Cargo una lista con los datos del csv
            string[] lines = File.ReadAllLines(_archivoCSV);
            Console.WriteLine(lines.Length);
            datos = new List<string>(lines);
            Console.Write(datos);
            gvw_datos.DataSource = datos;


        }
        }
    }

