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
        public string Datos = @"./datos";
        private Estado[] EstadosDeportistas = { new Estado("En Espera"), new Estado("Jugando"), new Estado("Finalizo") };
        private Estado[] EstadosCancha = { new Estado("Libre"), new Estado("Ocupada"), new Estado("Limpiando") };
        private Disciplina[] Disciplinas = { new Disciplina("Basket", 0), new Disciplina("Handball", 1), new Disciplina("Futbol", 1) };

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

        private Cancha Cancha;
        private dynamic[] DeportistasEnSistema;

        Random RndBasket;
        Random RndHandball;
        Random RndOcupacion;
        Random RndFutbol;


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

            Cancha = new Cancha(EstadosCancha[0], 0);
            DeportistasEnSistema = new Deportista[6];

            RndBasket = new Random(Guid.NewGuid().GetHashCode());
            RndHandball = new Random(Guid.NewGuid().GetHashCode());
            RndOcupacion = new Random(Guid.NewGuid().GetHashCode());
            RndFutbol = new Random(Guid.NewGuid().GetHashCode());

        }
        #endregion
        #region Calculos
        // Seccion para calcular tiempos de eventos a partir de un rnd siguiendo su distribucion correspondiente
        public double CalcularLlegadaFutbol(double rnd) {
            return GeneradorNros.Exponencial(LimsLlegFutbol, rnd);
         }
        public double CalcularLlegadaBasket(double rnd) {
            return GeneradorNros.Uniforme(LimsLlegBasket[0], LimsLlegBasket[1], rnd);
         }
        public double CalcularLlegadaHandball(double rnd) {
            return GeneradorNros.Uniforme(LimsLlegHandball[0], LimsLlegHandball[1], rnd);
         }

        public double CalcularFinOcupacionCancha(double rnd, Deportista d)
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
        #endregion

        #region Eventos
        public void AsignarDeportistaAGrupoSistema(Deportista dep)
        {
            for (int i = 0; i < DeportistasEnSistema.Length; i++)
            {
                if (DeportistasEnSistema[i] == -1)
                {
                    DeportistasEnSistema[i] = dep;
                    break;
                }
            }
        }

        public void GenerarLlegadaSegunEvento(string[]linea, double[] evento)
        {
            double rnd;
            double tEntreLleg;

            if (evento[1] == 0) // Llegada Basket
            {
                rnd = RndBasket.NextDouble();
                tEntreLleg = CalcularLlegadaBasket(rnd);

                linea[2] = rnd.ToString();
                linea[3] = tEntreLleg.ToString();
                linea[4] = (evento[0] + tEntreLleg).ToString();
            }
            else if (evento[1] == 1) // Llegada Handball
            {
                rnd = RndHandball.NextDouble();
                tEntreLleg = CalcularLlegadaHandball(rnd);

                linea[5] = rnd.ToString();
                linea[6] = tEntreLleg.ToString();
                linea[7] = (evento[0] + tEntreLleg).ToString();
            }
            else if (evento[1] == 2) // Llegada Fútbol 
            {
                rnd = RndFutbol.NextDouble();
                tEntreLleg = CalcularLlegadaFutbol(rnd);

                linea[8] = rnd.ToString();
                linea[9] = tEntreLleg.ToString();
                linea[10] = (evento[0] + tEntreLleg).ToString();
            }
        }
        public Deportista CrearNuevoDeportista(double[] ev, bool estaLibre, string[] linea)
        {
            Deportista dep;
            Estado estado;

            if (estaLibre) estado = EstadosDeportistas[1];
            else
            {
                estado = EstadosDeportistas[0];
                Cancha.SumarACola();
                linea[16] = Cancha.getTamCola().ToString();
            }

            if (ev[1] == 0) dep = new Deportista(ev[0], estado, Disciplinas[0]); // Llegada Basket
            if (ev[1] == 1) dep = new Deportista(ev[0], estado, Disciplinas[1]); // Llegada Handball
            else dep = new Deportista(ev[0], estado, Disciplinas[2]); // Llegada Futbol

            if (estaLibre) // si esta vacia la cancha, genera una nueva ocupacion
            {
                double rnd = RndOcupacion.NextDouble();
                double tOcup = CalcularFinOcupacionCancha(rnd, dep);

                linea[11] = dep.getNombreDisc(); // quien juega
                linea[12] = rnd.ToString(); 
                linea[13] = tOcup.ToString();
                linea[14] = (tOcup + ev[0]).ToString(); // prox llegada

                Cancha.SetEstado(EstadosCancha[1]);
                linea[15] = Cancha.getNombreEstado();
            }

            return dep;
        }

        public string[] Llegada(string[] lineaAnt, double[] proximoEv)
        {
            string[] linea = lineaAnt;
            int contLlegadas = int.Parse(linea[25]) + 1; //sumamos 1 a las llegadas
            int retirados = int.Parse(linea[26]);

            BorrarColumnasSegunEvento(linea, proximoEv[1]); // borramos columnas innecesarias
            
            // Generar Prox llegada         
            GenerarLlegadaSegunEvento(linea, proximoEv); 
            
            if (!Cancha.HayMenosDe5EnCola()) // chequear TamCola
            {
                retirados++; // como se retira, sumamos 1 a retirados sin jugar
            }
            else
            {
                Deportista dep = CrearNuevoDeportista(proximoEv, Cancha.EstaLibre(), linea); // Creamos deportista
                AsignarDeportistaAGrupoSistema(dep); // Lo asignamos a un grupo posicional
            }

            // actualizar acumuladores
            linea[25] = contLlegadas.ToString();
            linea[26] = retirados.ToString();
            EscribirDeportistas(linea);
            
            return linea;
        }

        public int BuscarDeportistaJugando()
        {
            // Busca el deportista que está en estado jugando en este momento
            int jugando = -1;

            for(int i = 0; i < DeportistasEnSistema.Length; i++)
            {
                if (DeportistasEnSistema[i] == -1) continue;
                if (DeportistasEnSistema[i].estaJugando())
                {
                    jugando = i;
                }
            }

            return jugando;
        }

        public void EscribirDeportistas(string[] linea)
        {
            // Escribe la seccion de los grupos al final del vector registrado
            // pos representa el puntero en el vector
            int pos = 27;
            for (int i = 0;i < DeportistasEnSistema.Length; i++)
            {
                if (DeportistasEnSistema[i] == -1)
                {
                    // Si no hay deportista escribe espacios en blanco
                    linea[pos] = "";
                    linea[pos+1] = "";
                    linea[pos+2] = "";
                }
                else
                {
                    // Si hay deportista escribe sus datos
                    linea[pos] = DeportistasEnSistema[i].getNombreEstado();
                    linea[pos + 1] = DeportistasEnSistema[i].getTiempoLleg().toString();
                    linea[pos + 2] = DeportistasEnSistema[i].getNombreDisc();
                }

                pos += 3; // movemos el puntero
            }
        }

        public int BuscarProximoAJugar(double reloj)
        {
            // busca el proximo deportista a jugar a partir de la cola
            int AJugar = -1;
            double t = reloj;
            for (int i = 0; i < DeportistasEnSistema.Length; i++)
            {
                if (DeportistasEnSistema[i] == -1) continue;
                if (DeportistasEnSistema[i].esProximoAJugar(t))
                {
                    if (AJugar == -1) // todavía no se encontró deportista, se asigna al primero encontrado
                    {
                        AJugar = i;
                        t = DeportistasEnSistema[i].getTiempoLleg();
                        continue;
                    }
                    // sino se chequea quien tiene mas prioridad
                    else if (DeportistasEnSistema[i].GetPrioridad() > DeportistasEnSistema[AJugar].GetPrioridad()) 
                    {
                        AJugar = i;
                        t = DeportistasEnSistema[i].getTiempoLleg();
                    }
                }
            }
            return AJugar;
        }

        public void SumarAFinDeEspera(string[] linea, Deportista deportista, double reloj)
        {
            // Realiza cálculos estadísticos y actualiza el vector según quién juega
            double calcAC;
            int cont;
            if(deportista.getNombreDisc() == "Basket")
            {
                calcAC = double.Parse(linea[19]) + (reloj - deportista.getTiempoLleg());
                cont = int.Parse(linea[22]) + 1;

                linea[19] = calcAC.ToString();
                linea[22] = cont.ToString();
            }
            else if (deportista.getNombreDisc() == "Futbol")
            {
                calcAC = double.Parse(linea[20]) + (reloj - deportista.getTiempoLleg());
                cont = int.Parse(linea[23]) + 1;

                linea[20] = calcAC.ToString();
                linea[23] = cont.ToString();
            }
            else if (deportista.getNombreDisc() == "Handball")
            {
                calcAC = double.Parse(linea[21]) + (reloj - deportista.getTiempoLleg());
                cont = int.Parse(linea[24]) + 1;

                linea[21] = calcAC.ToString();
                linea[24] = cont.ToString();
            }
        }

        public void BorrarColumnas(string[] linea, int[] columnas)
        {
            // borrar las columnas pasadas como parámetro del vector
            foreach(int numero in columnas)
            {
                linea[numero] = "";
            }
        }

        public void BorrarColumnasSegunEvento(string[] linea, double evento)
        {
            if(evento == 0) // Llegada Basket
            {
                BorrarColumnas(linea, new int[] { 5, 6, 8, 9, 11, 12, 13, 17, 18 });
            }
            else if (evento == 1) // Llegada Handball
            {
                BorrarColumnas(linea, new int[] { 2, 3, 8, 9, 11, 12, 13, 17, 18, });
            }
            else if (evento == 2) // Llegada Fútbol 
            {
                BorrarColumnas(linea, new int[] { 2, 3, 5, 6, 11, 12, 13, 17, 18 });
            }
            else if (evento == 3) // Fin Ocupacion
            {
                BorrarColumnas(linea, new int[] { 2, 3, 5, 6, 8, 9, 11, 12, 13, 14, 17, 18 });
            } else if (evento == 4) // Limpieza
            {
                BorrarColumnas(linea, new int[] { 2, 3, 5, 6, 8, 9, 11, 12, 13 });
            }
        }

        public string[] FinOcupacion(string[] lineaAnt, double[] proximoEv)
        {
            // Lleva a cabo el evento fin ocupacion
            string[] linea = lineaAnt;

            linea[0] = Eventos[3]; // especificamos evento
            linea[1] = proximoEv[0].ToString(); // especificamos reloj

            // borramos columnas innecesarias
            BorrarColumnasSegunEvento(linea, proximoEv[1]);
            
            // buscar grupo Jugando
            int jugando = BuscarDeportistaJugando();
            DeportistasEnSistema[jugando].SetEstado(EstadosDeportistas[2]); // actualizar estado de deportista a FINALIZADO

            // chequear si alguien está en cola
            if (Cancha.getTamCola() == 0)
                // no hay nadie en cola, se limpia
            {
                // asignamos el valor maximo al evento finOcupacion
                tDeEventos[3] = (double)Int32.MaxValue;

                tDeEventos[4] = proximoEv[0] + TLimpieza; // calculamos t de fin de limpieza
                Cancha.SetEstado(EstadosCancha[2]); // actualizar estado de cancha a LIMPIANDO

                linea[15] = Cancha.getNombreEstado(); // escribimos el estado de la cancha

                // escribimos los datos sobre la limpieza
                linea[17] = TLimpieza.ToString();
                linea[18] = tDeEventos[4].ToString();
            }
            else
            {
                int proximoAjugar = BuscarProximoAJugar(proximoEv[0]); //buscamos el proximo a jugar
                DeportistasEnSistema[proximoAjugar].SetEstado(EstadosDeportistas[1]); // actualizamos su estado a JUGANDO
                linea[11] = DeportistasEnSistema[proximoAjugar].getNombreDisc(); // buscamos de que disciplina es quien juega

                double rnd = RndOcupacion.NextDouble(); // generamos nueva ocupacion
                linea[12] = rnd.ToString(); // RND Ocupación
                double generado = CalcularFinOcupacionCancha(rnd, DeportistasEnSistema[proximoAjugar]);
                linea[13] = generado.ToString(); // Duracion de jugada
                tDeEventos[3] = generado + proximoEv[0];
                linea[14] = tDeEventos[3].ToString();

                SumarAFinDeEspera(linea, DeportistasEnSistema[proximoAjugar], proximoEv[0]); // Actualizamos acumuladores

            }
            EscribirDeportistas(linea);
            DeportistasEnSistema[jugando] = -1;
            return linea;
        }

        public string[] FinLimpieza(string[] lineaAnt, double[] proximoEv)
        {
            string[] linea = lineaAnt;
            if (Cancha.getTamCola() > 0)
            {
            }
            return linea;
        }
        public string[] FinSimulacion(string[] lineaAnt, double[] proximoEv)
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
            double rnd = RndBasket.NextDouble();
            lineaAnt[2] = rnd.ToString();
            tDeEventos[0] = CalcularLlegadaBasket(rnd);
            lineaAnt[3] = tDeEventos[0].ToString();
            lineaAnt[4] = lineaAnt[3];

            rnd = RndHandball.NextDouble();
            lineaAnt[5] = rnd.ToString();
            tDeEventos[1] = CalcularLlegadaHandball(rnd);
            lineaAnt[6] = tDeEventos[1].ToString();
            lineaAnt[7] = lineaAnt[6];

            rnd = RndFutbol.NextDouble();
            lineaAnt[8] = rnd.ToString();
            tDeEventos[2] = CalcularLlegadaFutbol(rnd);
            lineaAnt[9] = tDeEventos[2].ToString();
            lineaAnt[10] = lineaAnt[6];

            // Ocupacion Cancha : Inicio no hay nada
            tDeEventos[3] = (double)Int32.MaxValue;
            BorrarColumnas(linea, new int[] { 11, 12, 13, 14 });

            // Iniciar Cancha y Deportistas en sistema
            lineaAnt[15] = Cancha.getNombreEstado();
            lineaAnt[16] = Cancha.getTamCola().ToString();

            // Limpieza : Inicio no hay nada
            tDeEventos[4] = (double)Int32.MaxValue;
            BorrarColumnas(linea, new int[] { 17, 18 });

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

                if (proximoEvento[1] == 0 || proximoEvento[1] == 1 || proximoEvento[1] == 2) { linea = Llegada(lineaAnt, proximoEvento); }
                else if (proximoEvento[1] == 3) { linea = FinOcupacion(lineaAnt, proximoEvento); }
                else if (proximoEvento[1] == 4) { linea = FinLimpieza(lineaAnt, proximoEvento); }
                else { 
                    linea = FinSimulacion(lineaAnt, proximoEvento); 
                    CSVWriter.WriteLine(linea); // escribimos linea fin de simulacion
                    fin = true;
                }

                if (proximoEvento[0] >= InicioImp && contadorIteraciones < Iteraciones)
                {
                    if (contadorIteraciones == 0)
                    {
                        linea[0] = "Inicio Impresion";
                        linea[1] = InicioImp.ToString();
                    }
                    CSVWriter.WriteLine(linea);
                    contadorIteraciones++;
                }
                
                lineaAnt = linea; // guardamos la linea anterior antes de la proxima iteracion
            }

            CSVWriter.Close();
        }
    }
}
