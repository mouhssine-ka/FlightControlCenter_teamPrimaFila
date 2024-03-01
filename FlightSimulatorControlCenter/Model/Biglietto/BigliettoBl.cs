using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Model.Volo;
using MyNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Biglietto
{
    internal class BigliettoBl
    {

        public int BigliettoId { get; set; }
        public VoloBl Volo { get; set; }
        public int PostiDaPrenotare { get; set; }
        public decimal ImportoTotale { get; set; }
        public DateTime DataAcquisto { get; set; }

        public BigliettoBl(int bigliettoId, VoloBl voloBl, int postiDaPrenotare, decimal importoTotale, DateTime dataAcquisto)
        {

            BigliettoId = bigliettoId;
            Volo = voloBl;
            PostiDaPrenotare = postiDaPrenotare;
            ImportoTotale = importoTotale;
            DataAcquisto = dataAcquisto;
        }

        public static BigliettoBl BigliettoBlFactory(int bigliettoId, VoloBl voloBl, int postiDaPrenotare, decimal importoTotale, DateTime dataAcquisto)
        {
            return new BigliettoBl(bigliettoId, voloBl, postiDaPrenotare, importoTotale, dataAcquisto);
        }
    }
}
