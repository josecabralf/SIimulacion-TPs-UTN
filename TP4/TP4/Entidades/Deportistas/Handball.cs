using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades.Deportistas
{
    internal class Handball
    {
        public double tiempoLlegada;
        private string Estado = "";
        public int Prioridad = 0;

        public void Llegar(double tiempo, string estado = "En Espera")
        // Por ahi llega y juega directo
        {
            Estado = estado;
            tiempoLlegada = tiempo;
        }

        public void Jugar()
        {
            Estado = "Jugando";
        }

        public void Finalizar()
        {
            Estado = "Finalizo";
        }

        public string getEstado()
        {
            return Estado;
        }
    }
}
