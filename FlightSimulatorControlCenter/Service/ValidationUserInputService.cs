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
    }
}
