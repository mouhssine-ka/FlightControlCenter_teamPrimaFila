using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Validation
{
    public class ValidationForUserVoloCreationResponse
    {
        public UserInputValidationEnum ValidationResult { get; set; }
        public List<string> ValidationErrors { get; set; }

        public long AereoId { get; set; }
        public decimal CostPosto { get; set; }
        public string CittaPartenza { get; set; }
        public string CittaArrivo { get; set; }
        public DateTime OrarioPartenza { get; set; }
        public DateTime OrarioArrivo { get; set; }

        public ValidationForUserVoloCreationResponse()
        {
        }

        public ValidationForUserVoloCreationResponse(UserInputValidationEnum validationResult, List<string> validationErrors, long aereoId, decimal costoPosto, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo)
        {
            ValidationResult = validationResult;
            ValidationErrors = validationErrors;
            AereoId = aereoId;
            CostPosto = costoPosto;
            CittaPartenza = cittaPartenza;
            CittaArrivo = cittaArrivo;
            OrarioPartenza = orarioPartenza;
            OrarioArrivo = orarioArrivo;
        }
        public static ValidationForUserVoloCreationResponse ValidationForUserVoloCreationResponseValidFactory(long aereoId, decimal costoPosto, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo)
        {
            return new ValidationForUserVoloCreationResponse(UserInputValidationEnum.Valid, new List<string>(), aereoId, costoPosto, cittaPartenza, cittaArrivo, orarioPartenza, orarioArrivo);
        }

        public static ValidationForUserVoloCreationResponse ValidationForUserVoloCreationResponseNotValidFactory(List<string> validationErrors)
        {
            return new ValidationForUserVoloCreationResponse(UserInputValidationEnum.NotValid, validationErrors, 0, 0, string.Empty, string.Empty, new DateTime(), new DateTime());
        }

        public bool IsValid()
        {
            return ValidationResult == UserInputValidationEnum.Valid;
        }
    }
}
