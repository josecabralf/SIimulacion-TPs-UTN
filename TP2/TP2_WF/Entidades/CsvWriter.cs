using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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