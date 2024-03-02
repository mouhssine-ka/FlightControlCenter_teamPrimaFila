using FlightSimulatorControlCenter.Model.Validation;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter.Service
{
    public class ValidationUserInputService : IValidationUserInputService
    {
        public ValidationForUserAirplaneCreationResponse ValidateUserInputForAirplaneCreation(string codice, string colore, string numeroDiPosti)
        {
            var errorResult = new List<string>();

            var formCodice = codice;
            // X Ragazzi aggiungere controllo sul formato del codice per flotta
            if (string.IsNullOrWhiteSpace(codice)) {
                errorResult.Add("Valorizzare il campo codice");
            }

            var formColore = colore;
            // X Ragazzi aggiungere controlli sui colori
            if (string.IsNullOrWhiteSpace(colore))
            {
                errorResult.Add("Valorizzare il campo colore");
            }

            long formNumeroDiPosti = 0;
            // X Ragazzi aggiungere controlli sul numero minimo e massimo di posti
            if (string.IsNullOrWhiteSpace(numeroDiPosti))
            {
                errorResult.Add("Valorizzare il campo numeroDiPosti");
            }
            else {
                var conversioneNumPosti = long.TryParse(numeroDiPosti, out formNumeroDiPosti);
                if (!conversioneNumPosti)
                {
                    errorResult.Add("Il campo numero di posti deve essere un intero");
                }
            }                    
           
            if (errorResult.Any()) {
                return ValidationForUserAirplaneCreationResponse.ValidationForUserAirplaneCreationResponseNotValidFactory(errorResult);
            } else {
                return ValidationForUserAirplaneCreationResponse.ValidationForUserAirplaneCreationResponseValidFactory(formCodice, formColore, formNumeroDiPosti);
            }          
        }

        public ValidationForUserVoloCreationResponse ValidateUserInputForVoloCreation(long aereoId, decimal costoPosto, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo)
        {
            var errorResult = new List<string>();

            if (aereoId == -1)
            {
                errorResult.Add("Scegli un Aereo");
            }
            if(costoPosto < 0)
            {
                errorResult.Add("Il prezzo non può essere minore di zero");
            }
            if (string.IsNullOrWhiteSpace(cittaPartenza))
            {
                errorResult.Add("Valorizzare il campo Citta Partenza");
            }

            if (string.IsNullOrWhiteSpace(cittaArrivo))
            {
                errorResult.Add("Valorizzare il campo Citta Arrivo");
            }

            if(orarioPartenza < DateTime.Now)
            {
                errorResult.Add("Orario Partenza non valido (non puoi inserire una data precedente ad oggi)");
            }
            if (orarioArrivo < DateTime.Now)
            {
                errorResult.Add("Orario Arrivo non valido (non puoi inserire una data precedente ad oggi)");
            }
            if (orarioArrivo < orarioPartenza)
            {
                errorResult.Add("Orario Partenza non valido (data arrivo è precedente alla data di partenza)");
            }

            if (errorResult.Any())
            {
                return ValidationForUserVoloCreationResponse.ValidationForUserVoloCreationResponseNotValidFactory(errorResult);
            }
            else
            {
                return ValidationForUserVoloCreationResponse.ValidationForUserVoloCreationResponseValidFactory(aereoId, costoPosto, cittaPartenza, cittaArrivo, orarioPartenza, orarioArrivo);
            }

        }

    }
}
