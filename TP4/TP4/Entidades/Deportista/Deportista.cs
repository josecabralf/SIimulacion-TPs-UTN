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

        public Deportista(double tiempo, Estado estado, Disciplina tipo, int prio)
        {
            tiempoLlegada = tiempo;
            Estado = estado;
            Disciplina = tipo;
        }

        public void Llegar(double tiempo, string estado = "En Espera")
        {
            Estado.SetEstado(estado);
            tiempoLlegada = tiempo;
        }

        public void Jugar() => Estado.SetEstado("Jugando");

        public void Finalizar() => Estado.SetEstado("Finalizo");

        public int GetPrioridad()
        {
            return Disciplina.GetPrioridad();
        }

        public string[] GetDatos()
        {
            return new string[] { Estado.GetNombre(), tiempoLlegada.ToString(), Disciplina.GetNombre() };
        }
    }
}
