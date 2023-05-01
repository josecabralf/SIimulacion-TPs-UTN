using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_WF.Entidades
{
    internal class Experimento
    {
        string[] Comprar;

        Experimento()
        {
            Comprar = new string[] { "Definitivamente no", "Dudoso", "Definitivamente sí" };
        }

        bool Recuerda(double rnd)
        {
            if (rnd < 0.4) return true;
            return false;
        }

        string Comprara(double rnd, bool recuerda)
        {
            if(recuerda)
            {
                if (rnd < 0.3)
                {
                    return Comprar[0];
                } else if (rnd < 0.6)
                {
                    return Comprar[1];
                }
                return Comprar[2];
            }else
            {
                if (rnd < 0.5)
                {
                    return Comprar[0];
                }
                else if (rnd < 0.9)
                {
                    return Comprar[1];
                }
                return Comprar[2];
            }

        }
    }
}
