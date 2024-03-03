using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Volo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Validation
{
    public class ValidationForUserVoloUpdateResponse
    {
        public UserInputValidationEnum ValidationResult { get; set; }
        public List<string> ValidationErrors { get; set; }
        public long PostiRimanenti { get; set; }
        public decimal CostoDelPosto { get; set; }
        public string CittaPartenza { get; set; }
        public string CittaArrivo { get; set; }
        public DateTime OrarioPartenza { get; set; }
        public DateTime OrarioArrivo { get; set; }
        public VoloBl Volo { get; set; }

        public ValidationForUserVoloUpdateResponse(UserInputValidationEnum validationResult, List<string> validationErrors, long postiRimanenti, decimal costoDelPosto, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo, VoloBl volo)
        {
            ValidationResult = validationResult;
            ValidationErrors = validationErrors;
            PostiRimanenti = postiRimanenti;
            CostoDelPosto = costoDelPosto;
            CittaPartenza = cittaPartenza;
            CittaArrivo = cittaArrivo;
            OrarioPartenza = orarioPartenza;
            OrarioArrivo = orarioArrivo;
            Volo = volo;
        }

        public static ValidationForUserVoloUpdateResponse ValidationForUserVoloUpdateResponseValidFactory(long postiRimanenti, decimal costoDelPosto, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo, VoloBl volo)
        {
            return new ValidationForUserVoloUpdateResponse(UserInputValidationEnum.Valid, new List<string>(), postiRimanenti, costoDelPosto, cittaPartenza, cittaArrivo, orarioPartenza, orarioArrivo, volo);
        }
        public static ValidationForUserVoloUpdateResponse ValidationForUserVoloUpdateResponseNotValidFactory(List<string> validationErrors) 
        {
            return new ValidationForUserVoloUpdateResponse(UserInputValidationEnum.NotValid, validationErrors, 0, 0, string.Empty, string.Empty, new DateTime(), new DateTime(), null);   
        }
        public bool IsValid()
        {
            return ValidationResult == UserInputValidationEnum.Valid;
        }
    }
}
