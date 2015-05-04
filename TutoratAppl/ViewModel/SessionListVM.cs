using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.ViewModel
{
    public class SessionListVM
    {
        public DateTime DateTimeSession { get; set; }
        public string HelpedFirstName { get; set; }
        public string HelpedLastName { get; set; }
        public int ID { get; set; }
        public int SessionLenght { get; set; }
        public string TutorFirstName { get; set; }
        public string TutorLastName { get; set; }

        public string ToString()
        {

        }
    }
}
