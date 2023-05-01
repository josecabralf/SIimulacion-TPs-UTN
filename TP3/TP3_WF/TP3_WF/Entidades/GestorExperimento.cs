using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_WF.Entidades
{
    internal class GestorExperimento
    {
        CsvWriter Writer;
        string CSV = @"../../Recursos/datos.csv";
        Experimento experimento;

        GestorExperimento()
        {
            Writer = new CsvWriter(CSV);
            experimento = new Experimento();
        }

        public void realizarExperimento(int nroExpemimentos, int desde, int cant)
        {

        }
    }
}
