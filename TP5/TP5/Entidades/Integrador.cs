using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            StreamWriter csvWriter = new StreamWriter(@$"./Integraciones/{nomEvento}.csv");
            #region Inicializacion
            double t;
            double C = (double) contador;
            double d;

            double dPrima;
            double tProximo = 0;
            double dProximo = 0;

            string[] linea = new string[5];
            string impresion;
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

                }
            }
            while (d < dObjetivo);

            csvWriter.Close();
            return t;
        }
    }
}
