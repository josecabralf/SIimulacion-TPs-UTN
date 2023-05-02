using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;

namespace TP3_WF.Entidades
{
    internal class CsvReader
    {
        StreamReader streamReader;

        public CsvReader(string filePath)
        {
            // Instancia el objeto que nos permite escribir en el archivo CSV
            streamReader = new StreamReader(filePath);
        }

        public double LoadCsvData(DataTable dt)
        {
            // Carga con los numeros contenidos en el CSV una tabla, un array (frecObs) con las frecuencias
            // observadas de cada intervalo y otro array (arrayLimSup) con los limites superiores de cada intervalo
            
            try
            {
               // Crea la cabecera de la tabla
                
                dt.Columns.Add("Nro de Experimento");
                dt.Columns.Add("RND Recuerda");
                dt.Columns.Add("Recuerda");
                dt.Columns.Add("RND Compra");
                dt.Columns.Add("Compra");
                dt.Columns.Add("Cant Éxitos");

                string[] lineArray = new string[6] { "0", "", "", "", "", "1" };

                using (streamReader)
                {
                    string? currentLine;
                    // Leer las líneas del archivo y cargar la tabla de datos
                    while ((currentLine = streamReader.ReadLine()) != null)
                    {
                        lineArray = currentLine.Split(';');
                        DataRow lineRow = dt.NewRow();

                        lineRow["Nro de Experimento"] = lineArray[0];
                        lineRow["RND Recuerda"] = lineArray[1];
                        lineRow["Recuerda"] = lineArray[2];
                        lineRow["RND Compra"] = lineArray[3];
                        lineRow["Compra"] = lineArray[4];
                        lineRow["Cant Éxitos"] = lineArray[5];

                        dt.Rows.Add(lineRow);
                    }
                }

                // Se calcula la probabilidad de éxito
                double nroExp = double.Parse(lineArray[0]);
                double exitos = double.Parse(lineArray[5]);

                return (double)(exitos / nroExp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al cargar datos del CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}