using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.ViewModel
{
    public class HelpedListVM
    {
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return "Courriel: " + EmailAddress + ", Nom: " + FirstName + " " + LastName + ", ID: " + Id.ToString();
        }
    }
}
