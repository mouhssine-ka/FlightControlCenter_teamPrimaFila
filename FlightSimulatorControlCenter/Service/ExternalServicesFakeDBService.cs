using Clients.ImpiantiClient;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter.Service
{
    public class ExternalServicesFakeDBService : IExternalServicesService
    {
        private IConversionModelService _conversionService;

        public ExternalServicesFakeDBService(IConversionModelService conversionService) {
            _conversionService = conversionService;

            // Inizializzo il modello di db
            List<AereoBl> aerei = new List<AereoBl>() {
            AereoBl.AereoBlFactory(1, "AereoCod1", "Rosso", 10),
            AereoBl.AereoBlFactory(2,"AereoCod2", "Blu", 20),
            AereoBl.AereoBlFactory(3,"AereoCod3", "Verde", 10)
            };

            var flotta1 = FlottaBl.FlottaBlFactory(1, "WizzAir", "Attiva", aerei);

            if(!FakeDB.Flotte.Contains(flotta1))
            {
                FakeDB.AggiungiFlotta(flotta1);

            }

            List<AereoBl> aerei2 = new List<AereoBl>() {
            AereoBl.AereoBlFactory(4,"AereoCod4", "Rosso", 40),
            AereoBl.AereoBlFactory(5,"AereoCod5", "Blu", 50),
            AereoBl.AereoBlFactory(6,"AereoCod6", "Verde", 60)
            };

            var flotta2 = FlottaBl.FlottaBlFactory(2, "Rayanair", "Attiva", aerei2);

            FakeDB.AggiungiFlotta(flotta2);
        }

        public FlottaApi FlottaPOSTAsync(CreateFlottaRequest req)
        {
            List<AereoApi> aerei = new List<AereoApi>();
            var flotta1 = new FlottaApi() { IdFlotta=DateTime.Now.Ticks, Nome= req.NomeFlotta, Aerei= new List<AereoApi>() };

            var flottaToAdd = _conversionService.ConvertToBl(flotta1);

            FakeDB.AggiungiFlotta(flottaToAdd);
            return flotta1;
        }

        public List<FlottaApi> GetElencoFlotteAsync()
        {
            List<FlottaApi> flotte = new List<FlottaApi>();

            foreach (var f in FakeDB.Flotte)
            {
                var aerei = f.Aerei.Select(x => new AereoApi() {IdAereo= x.IdAereo, CodiceAereo= x.Codice, Colore= x.Colore, NumeroDiPosti=x.NumeroDiPosti });
                flotte.Add(new FlottaApi() { IdFlotta = f.IdFlotta, Nome = f.Nome, Aerei = aerei.ToList() });
            }

            return flotte;
        }

        public FlottaApi GetFlottaAsync(long idFLotta)
        {
            var f = FakeDB.GetFlottaSelezionataById(idFLotta);

            var aerei = f.Aerei.Select(x => new AereoApi() { IdAereo = x.IdAereo, CodiceAereo = x.Codice, Colore = x.Colore, NumeroDiPosti = x.NumeroDiPosti });
            return new FlottaApi() { IdFlotta = f.IdFlotta, Nome = f.Nome, Aerei = aerei.ToList() };
        }

        public AereoApi AereoPOSTAsync(CreateAereoRequest req)
        {
            var f = FakeDB.GetFlottaSelezionataById(req.IdFLotta);

            var aereo1 = new AereoApi() { IdAereo = DateTime.Now.Ticks, CodiceAereo = req.CodiceAereo, Colore = req.Colore, NumeroDiPosti = req .NumeroDiPosti};

            var AereoToAdd = _conversionService.ConvertToBl(aereo1);

            f.AddAereo(AereoToAdd);
           
            return aereo1;
        }

        public AereoApi AereoPutAsync(UpdateAereoRequest req)
        {
            var aereobl = FakeDB.GetAereoSelezionataByIdAereo(req.IdAereo);

            aereobl.Colore = req.Colore;
            aereobl.NumeroDiPosti = req.NumeroDiPosti;

            var aereo1 = new AereoApi() { IdAereo = aereobl.IdAereo, CodiceAereo = aereobl.Codice, Colore = aereobl.Colore, NumeroDiPosti = aereobl .NumeroDiPosti };
            return aereo1;
        }

        public AereoApi AereoDeleteAsync(long idAereo)
        {
            AereoBl aereobl = FakeDB.DeleteAereoSelezionataByIdAereo(idAereo);

            var aereo1 = new AereoApi() { IdAereo = aereobl.IdAereo, CodiceAereo = aereobl.Codice, Colore = aereobl.Colore, NumeroDiPosti = aereobl.NumeroDiPosti };

            return aereo1;
        }

        public List<VoloApi> GetElencoVoliAsync()
        {
            throw new NotImplementedException();
        }

        public VoloApi VoloPOSTAsync(CreateVoloRequest req)
        {
            throw new NotImplementedException();
        }
    }
}
