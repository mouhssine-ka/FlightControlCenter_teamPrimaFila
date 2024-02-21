using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter.Service
{
    public class ConversionModelService : IConversionModelService
    {
        public FlottaBl ConvertToBl(FlottaApi flottaApi)
        {
            // Converto in modello bl -> SubService per la conversione
            var aereiBl = flottaApi.Aerei.Select(x => ConvertToBl(x)).ToList();
            var flottaBl = FlottaBl.FlottaBlFactory(flottaApi.IdFlotta, flottaApi.Nome, "Attivo", aereiBl);

            return flottaBl;
        }

        public AereoBl ConvertToBl(AereoApi aereoApi)
        {
            // Converto in modello bl -> SubService per la conversione
            var aereoBl = AereoBl.AereoBlFactory(aereoApi.IdAereo, aereoApi.CodiceAereo, aereoApi.Colore, aereoApi.NumeroDiPosti);

            return aereoBl;
        }

        public List<FlottaBl> ConvertToBl(List<FlottaApi> flotte)
        {
            return flotte.Select(x => ConvertToBl(x)).ToList();
        }
    }
}
