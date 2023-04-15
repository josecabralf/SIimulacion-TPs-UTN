using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_WF.Entidades
{
    class ValidadorParametros
    {
        public ValidadorParametros()
        {

        }

        public bool validarSuperiorACero(int n)
        {
            // Valida que el parametro ingresado sea superior a 0
            return n > 0;
        }

        public bool validarParametrosUniforme(double a, double b)
        {
            // Valida que el limite inferior de la distribución sea menor al superior
            return a < b;
        }


    }
}
