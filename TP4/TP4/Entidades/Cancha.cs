using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    internal class Cancha
    {
        public string? Estado;

        public Cancha() => Liberar();

        public void Liberar()
        {
            Estado = "Libre";
        }

        public void Ocupar()
        {
            Estado = "Ocupado";
        }

        public void Limpiar()
        {
            Estado = "Limpiando";
        }
    }
}
