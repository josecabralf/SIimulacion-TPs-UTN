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

        public Cancha(Estado estado) 
        {
            Estado = estado;
        }

        public void Liberar()
        {
            Estado.SetEstado("Libre");
        }

        public void Ocupar()
        {
            Estado.SetEstado("Ocupado");
        }

        public void Limpiar()
        {
            Estado.SetEstado("Limpiando");
        }

        public string getEstado()
        {
            return Estado.GetNombre();
        }
    }
}
