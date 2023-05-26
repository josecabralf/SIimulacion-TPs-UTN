using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4.Entidades
{
    internal class GestorSimulacion
    {
        #region Propiedades
        private string Datos = @"./datos";
        private Estado[] EstadosDeportistas = { new Estado("En Espera"), new Estado("Jugando"), new Estado("Finalizo") };
        private Estado[] EstadosCancha = { new Estado("Libre"), new Estado("Ocupada"), new Estado("Limpiando") };
        private Disciplina[] Disciplinas = { new Disciplina("Basket", 0), new Disciplina("Futbol", 1), new Disciplina("Handball", 1) };

        private string[] Eventos = { "Llegada Basket", "Llegada Handball", "Llegada Futbol", "Fin Ocupacion", "Fin de Limpieza", "Fin de Simulacion" };
        private double[] tDeEventos; // mismo orden que vector arriba

        private double LimsLlegFutbol;
        private double[] LimsLlegHandball;
        private double[] LimsLlegBasket;

        private double[] LimsOcupFutbol;
        private double[] LimsOcupHandball;
        private double[] LimsOcupBasket;

        private double TLimpieza;

        private double InicioImp;
        private int Iteraciones;

        #endregion
        #region Constructor
        public GestorSimulacion(double inicioImp, int Cantidad, double FinSim, double limsLlegFutbol, double[] limsLlegHandball, 
            double[] limsLlegBasket, double[] limsOcupFutbol, double[] limsOcupHandball, double[] limsOcupBasket, 
            double tLimpieza) 
        {
            tDeEventos = new double[6];
            tDeEventos[5] = FinSim;
            InicioImp = inicioImp;
            Iteraciones = Cantidad;

            LimsLlegFutbol = limsLlegFutbol;
            LimsLlegHandball = limsLlegHandball;
            LimsLlegBasket = limsLlegBasket;

            LimsOcupFutbol = limsOcupFutbol;
            LimsOcupHandball = limsOcupHandball;
            LimsOcupBasket = limsOcupBasket;

            TLimpieza = tLimpieza;
        }
        #endregion
        #region Calculos
        public double CalcularLlegadaFutbol(double rnd) {
            return GeneradorNros.Exponencial(LimsLlegFutbol, rnd);
         }
        public double CalcularLlegadaBasket(double rnd) {
            return GeneradorNros.Uniforme(LimsLlegBasket[0], LimsLlegBasket[1], rnd);
         }
        public double CalcularLlegadaHandball(double rnd) {
            return GeneradorNros.Uniforme(LimsLlegHandball[0], LimsLlegHandball[1], rnd);
         }

        public double OcupacionCancha(double rnd, Deportista d)
        {
            string disc = d.getNombreDisc();
            double generado = 0;
            switch (disc)
            {
                case "Futbol":
                    generado = GeneradorNros.Uniforme(LimsOcupFutbol[0], LimsOcupFutbol[1], rnd); break;
                case "Basket":
                    generado = GeneradorNros.Uniforme(LimsOcupBasket[0], LimsOcupBasket[1], rnd); break;
                case "Handball":
                    generado = GeneradorNros.Uniforme(LimsOcupHandball[0], LimsOcupHandball[1], rnd); break;
                default:
                    break;
            }
            return generado;
        }

        public double CalcularTiempoEvento(double tiempoEntre, double reloj) {
            return tiempoEntre + reloj;
        }
        #endregion
        #region Eventos
        public string[] LlegadaBasket(string[] lineaAnt)
        {
            string[] linea = new string[45];
            return linea;
        }

        public string[] LlegadaFutbol(string[] lineaAnt)
        {
            string[] linea = new string[45];
            return linea;
        }

        public string[] LlegadaHandball(string[] lineaAnt)
        {
            string[] linea = new string[45];
            return linea;
        }

        public string[] FinOcupacion(string[] lineaAnt)
        {
            string[] linea = new string[45];
            return linea;
        }

        public string[] FinLimpieza(string[] lineaAnt)
        {
            string[] linea = new string[45];
            return linea;
        }
        public string[] FinSimulacion(string[] lineaAnt)
        {
            string[] linea = lineaAnt;
            linea[0] = Eventos[5];
            return linea;
        }
        #endregion
        public void Simular()
        {
            #region Inicializacion
            // Para escribir archivo CSV
            StreamWriter CSVWriter = new StreamWriter(Datos);
            string[] lineaAnt = new string[45];
            string[] linea = new string[45];

            // Reloj inicial
            double reloj = 0;
            lineaAnt[0] = "Inicializacion";
            lineaAnt[1] = reloj.ToString();

            // Llegadas
            Random rndBasket = new Random(Guid.NewGuid().GetHashCode());
            double rnd = rndBasket.NextDouble();
            lineaAnt[2] = rnd.ToString();
            tDeEventos[0] = CalcularLlegadaBasket(rnd);
            lineaAnt[3] = tDeEventos[0].ToString();
            lineaAnt[4] = lineaAnt[3];

            Random rndHandball = new Random(Guid.NewGuid().GetHashCode());
            rnd = rndHandball.NextDouble();
            lineaAnt[5] = rnd.ToString();
            tDeEventos[1] = CalcularLlegadaHandball(rnd);
            lineaAnt[6] = tDeEventos[1].ToString();
            lineaAnt[7] = lineaAnt[6];

            Random rndFutbol = new Random(Guid.NewGuid().GetHashCode());
            rnd = rndFutbol.NextDouble();
            lineaAnt[8] = rnd.ToString();
            tDeEventos[2] = CalcularLlegadaFutbol(rnd);
            lineaAnt[9] = tDeEventos[2].ToString();
            lineaAnt[10] = lineaAnt[6];

            // Ocupacion Cancha : Inicio no hay nada
            Random rndOcupacion = new Random(Guid.NewGuid().GetHashCode());
            tDeEventos[3] = 9999;
            lineaAnt[11] = "";
            lineaAnt[12] = "";
            lineaAnt[13] = "";
            lineaAnt[14] = "";

            // Iniciar Cancha y Deportistas en sistema
            Cancha cancha = new Cancha(EstadosCancha[0], 0);
            lineaAnt[15] = cancha.getNombreEstado();
            lineaAnt[16] = cancha.getTamCola().ToString();

            // Limpieza : Inicio no hay nada
            tDeEventos[4] = 9999;
            lineaAnt[17] = "";
            lineaAnt[18] = "";

            // Variables estadisticas
            // t espera AC 
            double tACB = 0;
            lineaAnt[19] = tACB.ToString();
            double tACH = 0;
            lineaAnt[20] = tACH.ToString();
            double tACF = 0;
            lineaAnt[21] = tACF.ToString();

            // contador fin espera
            int cFEB = 0;
            lineaAnt[22] = cFEB.ToString();
            int cFEH = 0;
            lineaAnt[23] = cFEH.ToString();
            int cFEF = 0;
            lineaAnt[24] = cFEF.ToString();

            // contador llegadas y retirados sin jugar
            int llegadas = 0;
            lineaAnt[25] = llegadas.ToString();
            int rsj = 0;
            lineaAnt[26] = rsj.ToString();

            Deportista[] enSistema = new Deportista[6];
            #endregion

            bool fin = false;
            double[] proximoEvento;
            int contadorIteraciones = 0;

            while (!fin)
            {
                proximoEvento = EventHandler.ProximoEvento(tDeEventos);

                if (proximoEvento[1] == 0) { linea = LlegadaBasket(lineaAnt); }
                else if (proximoEvento[1] == 1) { linea = LlegadaHandball(lineaAnt); }
                else if (proximoEvento[1] == 2) { linea = LlegadaFutbol(lineaAnt); }
                else if (proximoEvento[1] == 3) { linea = FinOcupacion(lineaAnt); }
                else if (proximoEvento[1] == 4) { linea = FinLimpieza(lineaAnt); }
                else { 
                    linea = FinSimulacion(lineaAnt); 
                    fin = true;
                }

                if (proximoEvento[0] >= InicioImp && contadorIteraciones < Iteraciones)
                {
                    CSVWriter.WriteLine(linea);
                    contadorIteraciones++;
                }
            }

            CSVWriter.Close();
        }
    }
}
