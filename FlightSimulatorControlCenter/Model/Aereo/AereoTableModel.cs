using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Model.Volo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Biglietto
{
    public class AereoTableModel
    {
        public long IdAereo { get; set; }
        public string Codice { get; set; }
        public string Colore { get; set; }
        public long NumeroDiPosti { get; set; }

        public AereoTableModel(long idAereo, string codice, string colore, long numeroDiPosti)
        {
            IdAereo = idAereo;
            Codice = codice;
            Colore = colore;
            NumeroDiPosti = numeroDiPosti;
        }

        public static AereoTableModel AereoTableModelFactory(long AereoId, string codice, string colore, long numeroDiPosti)
        { 
            return new AereoTableModel(AereoId, codice, colore, numeroDiPosti);
        }
    }
}
