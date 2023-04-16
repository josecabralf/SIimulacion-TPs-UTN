using System;
using System.IO;

namespace TP2_WF.Entidades
{
    public class CsvWriter
    {
        StreamWriter streamWriter;

        public CsvWriter(String filePath)
        {
            streamWriter = new StreamWriter(filePath);
        }

        public void WriteToCsvFile(decimal num)
        {
            streamWriter.WriteLine(num);
        }

        public void closeStream()
        {
            streamWriter.Close();
        }

        public void ClearFile(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);
        }
    }
}