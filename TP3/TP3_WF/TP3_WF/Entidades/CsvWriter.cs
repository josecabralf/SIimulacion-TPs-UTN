using System;
using System.IO;

namespace TP3_WF.Entidades
{
    public class CsvWriter
    {
        StreamWriter streamWriter;

        public CsvWriter(String filePath)
        {
            // Instancia el objeto que nos permite escribir en el archivo CSV
            streamWriter = new StreamWriter(filePath);
        }

        public void WriteToCsvFile(string[] res)
        {
            // Escribe una linea en el archivo CSV
            streamWriter.WriteLine(res);
        }

        public void closeStream()
        {
            // Cierra el archivo CSV
            streamWriter.Close();
        }
    }
}