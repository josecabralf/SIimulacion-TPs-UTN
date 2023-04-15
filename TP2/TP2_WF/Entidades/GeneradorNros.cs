using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_WF.Entidades
{
    class GeneradorNros
    {
            // Generador de nros aleatorios correspondientes a una Uniforme[A,B)
            void Uniforme(int tam_muestra, double a = 0, double b = 1)
            // Parametros de entrada: tamaño de la muestra, a = nro minimo y b = nro máximo
            // En caso de no introducirse a y/o b, se asume Uniforme[0,1)
            {
                // Se establecen las variables iniciales

                // nro_gen: será el nro generado en cada iteración del ciclo for.
                double nro_gen;
                decimal nro_gen_4dp;

                // rnd: nro aleatorio perteneciente a una Uniforme[0,1)
                Random rnd = new Random();

                for (int i = 0; i < tam_muestra; i++)
                {
                    // Aplicamos la fórmula para realizar la generación de nros que siguen una distribución Uniforme[A,B)
                    nro_gen = a + rnd.NextDouble() * (b - a);
                    nro_gen_4dp = Math.Truncate((decimal)nro_gen * 10000) / 10000;

                    // ACA DEBERÍA IR LO DE CARGARLO AL CSV
                    Console.WriteLine(nro_gen_4dp);
                }
            }

            // Generador de nros aleatorios correspondientes a una Normal según Método de Box-Muller
            void Normal_BoxMuller(int tam_muestra, double media = 0, double dev_est = 1)
            // Parametros de entrada: tamaño de la muestra, media y deviación estándar
            // En caso de no introducirse media y/o deviación estándar, se asume Normal(0,1)
            {
                // Se establecen las variables iniciales

                // rnd1 y rnd2: serán los dos random pertenecientes a una Uniforme[0,1) utilizados para la generación de nros.
                Random rnd1 = new Random();
                Random rnd2 = new Random();

                // Variables auxiliares para calculos intermedios:
                double b;
                double ang;

                // nro_gen1 y nro_gen2: serán los nros aleatorios generados por los rnd anteriores
                double nro_gen1;
                double nro_gen2;
                decimal nro_gen1_4dp;
                decimal nro_gen2_4dp;

                for (int i = 0; i < tam_muestra; i++)
                {
                    b = Math.Sqrt(-2 * Math.Log(rnd1.NextDouble()));
                    ang = 2 * Math.PI * rnd1.NextDouble();

                    nro_gen1 = media + dev_est * b * Math.Cos(ang);
                    nro_gen2 = media + dev_est * b * Math.Sin(ang);

                    nro_gen1_4dp = Math.Truncate((decimal)nro_gen1 * 10000) / 10000;
                    nro_gen2_4dp = Math.Truncate((decimal)nro_gen2 * 10000) / 10000;

                    // ACA DEBERÍA IR LO DE CARGARLO AL CSV
                    Console.WriteLine(nro_gen1_4dp);
                    Console.WriteLine(nro_gen2_4dp);
                }

            }

            // Generador de nros aleatorios correspondientes a una Normal según Método de Convolusion
            void Normal_Convolusion(int tam_muestra, double media = 0, double dev_est = 1)
            // Parametros de entrada: tamaño de la muestra, media y deviación estándar
            // En caso de no introducirse media y/o deviación estándar, se asume Normal(0,1)
            {
                // Se establecen las variables iniciales

                // rnd: nro aleatorio perteneciente a una Uniforme[0,1)
                Random rnd = new Random();

                // nro_gen: será el nro generado en cada iteración del ciclo for.
                double nro_gen;
                decimal nro_gen_4dp;

                // Variables para la Convolusión
                // acumulador: guardará la sumatoria de los 12 nros aleatorios generados
                double acumulador = 0;
                // Guardara el nro rnd generado
                double x;

                for (int i = 0; i < tam_muestra; i++)
                {
                    // Convolusión
                    for (int j = 0; j < 12; j++)
                    {
                        x = rnd.NextDouble();
                        acumulador += x;
                    };

                    // Se termina el método
                    nro_gen = (acumulador - 6) * dev_est + media;
                    nro_gen_4dp = Math.Truncate((decimal)nro_gen * 10000) / 10000;

                    // ACA DEBERÍA IR LO DE CARGARLO AL CSV
                    Console.WriteLine(nro_gen_4dp);

                    // Se resetea el acumulador para la próxima generación
                    acumulador = 0;
                }
            }

            // Generador de nros aleatorios correspondientes a una Exponencial Negativa mediante lambda
            void Exponencial_NegativaLambda(int tam_muestra, double lambda)
            // Parametros de entrada: tamaño de la muestra, lambda
            {
                // Se establecen las variables iniciales

                // rnd: nro aleatorio perteneciente a una Uniforme[0,1)
                Random rnd = new Random();

                // nro_gen: será el nro generado en cada iteración del ciclo for.
                double nro_gen;
                decimal nro_gen_4dp;

                for (int i = 0; i < tam_muestra; i++)
                {
                    nro_gen = (-1 / lambda) * Math.Log(1 - rnd.NextDouble());
                    nro_gen_4dp = Math.Truncate((decimal)nro_gen * 10000) / 10000;

                    // ACA DEBERÍA IR LO DE CARGARLO AL CSV
                    Console.WriteLine(nro_gen_4dp);
                }
            }

            // Generador de nros aleatorios correspondientes a una Exponencial Negativa mediante media
            void Exponencial_NegativaMedia(int tam_muestra, double media)
            // Parametros de entrada: tamaño de la muestra, media
            {
                // Se calcula lambda y se utiliza la función anterior
                double lambda = 1 / media;
                Exponencial_NegativaLambda(tam_muestra, lambda);
            }
        }
    }


