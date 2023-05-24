using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entidades.Deportista;

namespace TP4.Entidades
{
    internal class GestorSimulacion
    {
        private Estado[] EstadosDeportistas = { new Estado("En Espera"), new Estado("Jugando"), new Estado("Finalizo") };
        private Estado[] EstadosCancha = { new Estado("Libre"), new Estado("Ocupada"), new Estado("Limpiando") };
        private Disciplina[] Disciplinas = { new Disciplina("Basket", 0), new Disciplina("Futbol", 1), new Disciplina("Handball", 1) };
    }
}
