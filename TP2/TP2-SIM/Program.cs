using System.Security.Cryptography.X509Certificates;

namespace TP2_SIM
{
    class GeneradorNros
    {
        static void Main()
        {
            // Generador de nros aleatorios correspondientes a una Uniforme[A,B)
            void Uniforme(int tam_muestra, double a = 0, double b = 1)
            // Parametros de entrada: tamaño de la muestra, a = nro minimo y b = nro máximo
            // En caso de no introducirse a y/o b, se asume Uniforme[0,1)
            {
                // Se establecen las variables iniciales

                // nro_gen: será el nro generado en cada iteración del ciclo for.
                double nro_gen;

                // rnd: nro aleatorio perteneciente a una Uniforme[0,1)
                Random rnd = new Random();

                for (int i = 0; i<tam_muestra; i++)
                {
                    // Aplicamos la fórmula para realizar la generación de nros que siguen una distribución Uniforme[A,B)
                    nro_gen = a + rnd.NextDouble() * (b - a);

                    // ACA DEBERÍA IR LO DE CARGARLO AL CSV
                    Console.WriteLine(nro_gen);
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

                for (int i = 0; i<tam_muestra; i++)
                {
                    b = Math.Sqrt(-2 * Math.Log(rnd1.NextDouble()));
                    ang = 2 * Math.PI * rnd1.NextDouble();

                    nro_gen1 = media + dev_est * b * Math.Cos(ang);
                    nro_gen2 = media + dev_est * b * Math.Sin(ang);

                    // ACA DEBERÍA IR LO DE CARGARLO AL CSV
                    Console.WriteLine(nro_gen1);
                    Console.WriteLine(nro_gen2);
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

                // Variables para la Convolusión
                // acumulador: guardará la sumatoria de los 12 nros aleatorios generados
                double acumulador = 0;
                // Guardara el nro rnd generado
                double x;

                for (int i = 0; i<tam_muestra; i++)
                {
                    // Convolusión
                    for (int j = 0; j<12; j++)
                    {
                        x = rnd.NextDouble();
                        acumulador += x;
                    };

                    // Se termina el método
                    nro_gen = (acumulador - 6) * dev_est + media;

                    // ACA DEBERÍA IR LO DE CARGARLO AL CSV
                    Console.WriteLine(nro_gen);

                    // Se resetea el acumulador para la próxima generación
                    acumulador = 0;
                }
            }
        }
    }
}