using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    internal class GestorSimulacion
    {
        private int TiempoASimular;
        private int CantLineas;
        private int TiempoDesde;

        private double LlegadaFutbol;
        private double[] LlegadaHandball;
        private double[] LlegadaBasket;

        private double[] OcupacionFutbol;
        private double[] OcupacionHandball;
        private double[] OcupacionBasket;

        public GestorSimulacion(int tiempoASimular, int cantLineas, int tiempoDesde, double llegadaFutbol, double[] llegadaHandball, double[] llegadaBasket, double[] ocupacionFutbol, double[] ocupacionHandball, double[] ocupacionBasket)
        {
            TiempoASimular = tiempoASimular;
            CantLineas = cantLineas;
            TiempoDesde = tiempoDesde;

            LlegadaFutbol = llegadaFutbol;
            LlegadaHandball = llegadaHandball;
            LlegadaBasket = llegadaBasket;

            OcupacionFutbol = ocupacionFutbol;
            OcupacionHandball = ocupacionHandball;
            OcupacionBasket = ocupacionBasket;
        }
    }
}
