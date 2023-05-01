using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TP2_WF.Entidades;

namespace TP3_WF.Entidades
{
    internal class GestorExperimento
    {
        Experimento experimento;
        private string CondExito;

        public GestorExperimento()
        {
            experimento = new Experimento();
            CondExito = "Definitivamente sí";
        }

        private dynamic[] asignarResLinea(int i, double rnd1, bool rec, double rnd2, string comp, int exitos)
        {
            return new dynamic[] {i, rnd1, rec, rnd2, comp, exitos};
        }

        public void realizarExperimento(int nroExpemimentos, int desde, int cant)
        {
            // Inicializan los rnds
            Random rndRecuerda = new Random(Guid.NewGuid().GetHashCode());
            Random rndComprara = new Random(Guid.NewGuid().GetHashCode());

            // Variables de iteracion
            bool recuerda;
            double rnd1;

            string comprara;
            double rnd2;

            // Contador de Éxitos
            int exitos = 0;

            // Línea de resultados: [NroExp, rndRecuerda, Recuerda, rndComprara, Comprara, AC Exitos]
            dynamic[] res;

            for(int i = 1; i < nroExpemimentos+1; i++)
            {
                rnd1 = rndRecuerda.NextDouble();
                recuerda = experimento.Recuerda(rnd1);

                rnd2 = rndComprara.NextDouble();
                comprara = experimento.Comprara(rnd2, recuerda);

                if(comprara == CondExito) exitos++;
                
                res = asignarResLinea(i, rnd1, recuerda, rnd2, comprara, exitos);

                if(i >= desde && i < desde + cant)
                {
                    Console.WriteLine(string.Join(", ", res));
                }
            };
        }
    }
}
