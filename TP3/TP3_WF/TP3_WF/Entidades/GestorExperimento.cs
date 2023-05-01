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

        GestorExperimento()
        {
            Writer = new CsvWriter(CSV);
        }
    }
}
