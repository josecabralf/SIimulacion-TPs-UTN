using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace TP5.Entidades
{
    internal class Integrador
    {
        public static void generarLinea(string[] linea, double t, double d, double dPrima, double tProximo, double dProximo ) 
        {
            linea[0] = t.ToString();
            linea[1] = d.ToString();
            linea[2] = dPrima.ToString();
            linea[3] = tProximo.ToString();
            linea[4] = dProximo.ToString();
        }

        public static double Euler(double dObjetivo, int contador, bool flagImpresion, double h, string nomEvento)
        {    
            #region Excel
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(misValue);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            int nroFila = 2;

            if (flagImpresion)
            {
                xlWorkSheet.Cells[1, 1] = "ti";
                xlWorkSheet.Cells[1, 2] = "Di";
                xlWorkSheet.Cells[1, 3] = "dD/dt";
                xlWorkSheet.Cells[1, 4] = "ti + 1";
                xlWorkSheet.Cells[1, 5] = "Di + 1";
            }
            #endregion

            #region Inicializacion
            double t;
            double C = (double) contador;
            double d;

            double dPrima;
            double tProximo = 0;
            double dProximo = 0;
            #endregion

            do
            {
                t = tProximo;
                d = dProximo;

                dPrima = 0.6 * C + t;
                tProximo = t + h;
                dProximo = t + h * dPrima;

                if (flagImpresion)
                {
                    xlWorkSheet.Cells[nroFila, 1] = t;
                    xlWorkSheet.Cells[nroFila, 2] = d;
                    xlWorkSheet.Cells[nroFila, 3] = dPrima;
                    xlWorkSheet.Cells[nroFila, 4] = tProximo;
                    xlWorkSheet.Cells[nroFila, 5] = dPrima;
                    nroFila++;
                }
            }
            while (d < dObjetivo);

            if(flagImpresion)
            {
                xlWorkBook.SaveAs(@$"C:\Users\benja\Desktop\Nacho\Apuntes UTN\SIM\Simulacion-TPs-UTN\TP5\TP5\bin\Debug\net6.0-windows\Integraciones\{nomEvento}.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            return t;
        }
    }
}
