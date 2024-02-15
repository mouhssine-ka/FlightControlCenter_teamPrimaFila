using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Helper
{
    public static class FormUtils
    {
        public static bool FormIsOpen(string name) { 
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(q=> q.Name == name);
        
            return isOpen;
        }

    }
}
