using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    internal class GeneradorNros
    {
        private static double Truncar(double nro)
        {
            return Math.Truncate(nro * 10000) / 10000;
        }

        public static double Uniforme(double inf, double sup, double rnd)
        {
            return Truncar(inf + rnd * (sup - inf));
        }

        public static double Exponencial(double media, double rnd)
        {
            return Truncar(-media * Math.Log(1 - rnd));
        }
    }
}
