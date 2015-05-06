using System;
using System.Globalization;

namespace TutoratAppl.ViewModel
{
    public class SessionListVM
    {
        public DateTime DateTimeSession { get; set; }

        public string HelpedFirstName { get; set; }

        public string HelpedLastName { get; set; }

        public int Id { get; set; }

        public int SessionLenght { get; set; }

        public string TutorFirstName { get; set; }

        public string TutorLastName { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " = " + DateTimeSession.ToString("MM/dd/yyyy à HH:mm", CultureInfo.InvariantCulture)
                + ", " + HelpedFirstName + " " + HelpedLastName + ", " + SessionLenght.ToString() + ", " + TutorFirstName + " " + TutorLastName;
        }
    }
}