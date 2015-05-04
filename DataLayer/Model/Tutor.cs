using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Tutor : Entity
    {
        [Required]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<HelpedStudent> helpedStudents { get; set; }
        public virtual List<TutoringSession> tutoringSessions {get; set;}
    }
}
