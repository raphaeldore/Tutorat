using System.Collections.Generic;

namespace DataLayer.Model
{
    public class HelpedStudent : Entity
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public virtual List<TutoringSession> TutoringSessions { get; set; }
    }
}