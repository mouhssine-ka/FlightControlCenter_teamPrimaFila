﻿using FlightSimulatorControlCenter.Model.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Service.Int
{
    public interface IValidationUserInputService
    {
        ValidationForUserAirplaneCreationResponse ValidateUserInputForAirplaneCreation(string codice, string colore, string numeroDiPosti);
        ValidationForUserVoloCreationResponse ValidateUserInputForVoloCreation(long aereoId, decimal costoPosto, string cittaPartenza, string cittaArrivo, DateTime orarioPartenza, DateTime orarioArrivo);
    }
}
