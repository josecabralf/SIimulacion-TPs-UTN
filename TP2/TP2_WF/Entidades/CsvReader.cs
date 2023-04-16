using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP2_WF.Entidades
{
    internal class CsvReader
    {
        // Ruta relativa al archivo CSV con los datos
        private string _archivoCSV = @"../../Recursos/numeros.csv";

        public void LoadCsvData(DataTable dt, int[] frecObs, decimal[] minMax)
        {
            try
            {
                //Leer lineas del archivo:
                dt.Columns.Add("Numeros Generados");
                string[] lines = File.ReadAllLines(_archivoCSV);
                decimal anchoIntervalo = (minMax[1] - minMax[0]) / frecObs.Length;
                decimal[] arrayLimSup = establecerLimSupInt(frecObs, minMax[0], anchoIntervalo);

                foreach (string line in lines)
                {
                    dt.Rows.Add(line);
                    this.asignarIntervalo(decimal.Parse(line), frecObs, arrayLimSup);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al cargar datos del CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public decimal[] establecerLimSupInt(int[] frecObs, decimal minimo, decimal anchoIntervalo)
        {
            decimal[] arrayLimSup = new decimal[frecObs.Length];
            for (int i =0; i<arrayLimSup.Length; i++)
            {
                arrayLimSup[i] = minimo + (i + 1) * anchoIntervalo;
            }

            return arrayLimSup;
        }

        private void asignarIntervalo(decimal val, int[] frecObs, decimal[] arrayLimSup)
        {
            for (int i = 0; i<arrayLimSup.Length; i++)
            {
                if(val < arrayLimSup[i])
                {
                    frecObs[i]++;
                    return;
                }
            }
        }

    }
}