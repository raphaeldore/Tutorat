using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class TutoringSession : Entity
    {
        // Clé étrangère
        public int TutorId { get; set; }
        // Clé étrangère
        public int HelpedId { get; set; }
        public DateTime DateSession {get; set;}
        public int LenghtSession { get; set; }

        public virtual List<TutoringSession> tutoringSessions {get; set;}
    }
}
