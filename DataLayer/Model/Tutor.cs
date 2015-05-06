using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Tutor : Entity
    {
        public string EmailAddress { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual List<HelpedStudent> helpedStudents { get; set; }

        public virtual List<TutoringSession> tutoringSessions { get; set; }
    }
}