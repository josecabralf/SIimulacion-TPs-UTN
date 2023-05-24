using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    internal class Cancha
    {
        private Estado Estado;
        private int TamCola;

        public Cancha(Estado estado, int tamCola) 
        {
            Estado = estado;
            TamCola = tamCola;
        }

        public void SetEstado(Estado estado) => Estado = estado;

        public void SumarACola() => TamCola++;
        public void RestarACola() => TamCola--;

        public string[] GetDatos()
        {
            return new string[] { Estado.GetNombre(), TamCola.ToString() };
        }
    }
}
