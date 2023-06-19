using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades
{
    internal class Cancha
    {
        private Estado Estado;
        private int TamCola;
        private int ContLimpiezas;

        public Cancha(Estado estado, int tamCola) 
        {
            Estado = estado;
            TamCola = tamCola;
            ContLimpiezas = 0;
        }

        public void SetEstado(Estado estado) => Estado = estado;

        public void SumarACola() => TamCola++;

        public void SumarLimpieza() => ContLimpiezas++;

        public void RestarACola() => TamCola--;

        public bool HayMenosDe5EnCola()
        {
            if(TamCola<5) return true;
            return false;
        }

        public string getNombreEstado()
        {
            return Estado.GetNombre();
        }

        public int getTamCola()
        {
            return TamCola;
        }

        public int getContLimpiezas()
        {
            return ContLimpiezas;
        }

        public bool EstaLibre()
        {
            return (this.getNombreEstado() == "Libre");
        }
    }
}
