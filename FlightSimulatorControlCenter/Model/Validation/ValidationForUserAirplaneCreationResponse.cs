

namespace FlightSimulatorControlCenter.Model.Validation
{
    public class ValidationForUserAirplaneCreationResponse
    {
        public UserInputValidationEnum ValidationResult { get; set; }
        public List<string> ValidationErrors { get; set; }

        public string Codice { get; set; }
        public string Colore { get; set; }
        public long NumeroDiPosti { get; set; }

        public ValidationForUserAirplaneCreationResponse()
        {
        }

        protected ValidationForUserAirplaneCreationResponse(UserInputValidationEnum validationResult, List<string> validationErrors, string codice, string colore, long numeroDiPosti)
        {
            this.ValidationResult = validationResult;
            this.ValidationErrors = validationErrors;
            this.Codice = codice;
            this.Colore = colore;
            this.NumeroDiPosti = numeroDiPosti;
        }

        public static ValidationForUserAirplaneCreationResponse ValidationForUserAirplaneCreationResponseValidFactory(string codice, string colore, long numeroDiPosti)
        {
            return new ValidationForUserAirplaneCreationResponse(UserInputValidationEnum.Valid, new List<string>(), codice, colore, numeroDiPosti);
        }

        public static ValidationForUserAirplaneCreationResponse ValidationForUserAirplaneCreationResponseNotValidFactory(List<string> validationErrors)
        {
            return new ValidationForUserAirplaneCreationResponse(UserInputValidationEnum.NotValid, validationErrors, string.Empty, string.Empty, 0);
        }
        
        public bool IsValid()
        {
            return ValidationResult == UserInputValidationEnum.Valid;
        }
    }
}
