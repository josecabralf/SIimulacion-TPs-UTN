using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades.Deportista
{
    internal class Deportista
    {
        public double tiempoLlegada;
        private Estado Estado;
        public Disciplina Disciplina;

        public Deportista(double tiempo, Estado estado, Disciplina tipo)
        {
            tiempoLlegada = tiempo;
            Estado = estado;
            Disciplina = tipo;
        }

        public void SetEstado(Estado estado) => Estado = estado;

        public void Llegar(double tiempo, Estado estado)
        {
            SetEstado(estado);
            tiempoLlegada = tiempo;
        }

        public int GetPrioridad()
        {
            return Disciplina.GetPrioridad();
        }

        public string getNombreEstado()
        {
            return Estado.GetNombre();
        }

        public string getNombreDisc()
        {
            return Disciplina.GetNombre();
        }

        public string[] GetDatos()
        {
            return new string[] { this.getNombreEstado(), tiempoLlegada.ToString(), this.getNombreDisc() };
        }
    }
}
