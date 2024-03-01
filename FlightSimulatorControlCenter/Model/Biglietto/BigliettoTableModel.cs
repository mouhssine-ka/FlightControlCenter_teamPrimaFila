using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Model.Volo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Biglietto
{
    internal class BigliettoTableModel
    {
        public long BigliettoId {  get; set; }
        public long VoloId { get; set; }
        public int PostiDaPrenotare { get; set; }
        public decimal ImportoTotale { get; set; }
        public DateTime DataAcquisto { get; set; }

        public BigliettoTableModel(long bigliettoId, long voloId, int postiDaPrenotare, decimal importoTotale, DateTime dataAcquisto)
        { 
            BigliettoId = bigliettoId;
            VoloId = voloId;
            PostiDaPrenotare = postiDaPrenotare;
            ImportoTotale = importoTotale;
            DataAcquisto = dataAcquisto;
        }

        public static BigliettoTableModel FlottaTableModelFactory(long bigliettoId, long voloId, int postiDaPrenotare, decimal importoTotale, DateTime dataAcquisto)
        { 
            return new BigliettoTableModel(bigliettoId, voloId, postiDaPrenotare, importoTotale, dataAcquisto);
        }
    }
}
