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
            StreamWriter? csvWriter;
            string datos;

            #region Inicializacion
            double t;
            double C = (double) contador;
            double d;

            double dPrima;
            double tProximo = 0;
            double dProximo = 0;
            #endregion

            if (flagImpresion)
            {
                string archivo = @$".\Integraciones\{nomEvento}.txt";
                csvWriter = new StreamWriter(archivo);
                datos = string.Format("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", "ti", "Di", "dD/dt", "ti+1", "Di+1");
                csvWriter.WriteLine(datos);
            }
            else
            {
                csvWriter = new StreamWriter(@$".\Integraciones\A_null.txt");
            }

            do
            {
                t = tProximo;
                d = dProximo;

                dPrima = 0.6 * C + t;
                tProximo = t + h;
                dProximo = t + h * dPrima;

                if (flagImpresion)
                {
                    datos = string.Format("{0,-15:#0.0000} {1,-15:#0.0000} {2,-15:#0.0000} {3,-15:#0.0000} {4,-15:#0.0000}", 
                                            t, d, dPrima, tProximo, dProximo);
                    csvWriter.WriteLine(datos);
                }
            }
            while (d < dObjetivo);

            csvWriter.Close();
            return t;
        }
    }
}
