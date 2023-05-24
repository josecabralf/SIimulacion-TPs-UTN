using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    internal class Estado
    {
        private string Nombre;

        public Estado(string nombre)
        {
            Nombre = nombre;
        }

        public void SetEstado(string nombre)
        {
            Nombre= nombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}
