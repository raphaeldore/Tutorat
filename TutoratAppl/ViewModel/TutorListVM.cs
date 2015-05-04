using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.ViewModel
{
    class TutorListVM
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int ID { get; set; }

        public string ToString()
        {
            return "Courriel: " + EmailAddress + ", Nom: " + FirstName + " " + LastName + ", ID: " + ID.ToString();
        }
    }
}