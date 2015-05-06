using System;
using System.Collections.Generic;

namespace DataLayer.Model
{
    public class TutoringSession : Entity
    {
        // Clé étrangère
        public int TutorId { get; set; }

        // Clé étrangère
        public int HelpedStudentId { get; set; }

        public DateTime DateSession { get; set; }

        public int LenghtSession { get; set; }

        public virtual List<TutoringSession> tutoringSessions { get; set; }

        public HelpedStudent helpedStudent { get; set; }

        public Tutor tutor { get; set; }
    }
}