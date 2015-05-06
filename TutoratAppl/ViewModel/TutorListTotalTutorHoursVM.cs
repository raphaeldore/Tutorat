using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.ViewModel
{
    public class TutorListTotalTutorHoursVM
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int TotalTutoringHours { get; set; }
        
        public override string ToString()
        {
            return "Nom: " + FirstName + " " + LastName + " "  + "Courriel: " + EmailAddress + "Total Heures tutorat: " + TotalTutoringHours.ToString();
        }
    }
}
