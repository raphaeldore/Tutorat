﻿namespace TutoratAppl.ViewModel
{
    public class TutorListTotalTutorHoursVM
    {
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TotalTutoringHours { get; set; }

        public override string ToString()
        {
            return "Nom: " + FirstName + " " + LastName + " " + "Courriel: " + EmailAddress + "Total Heures tutorat: " + TotalTutoringHours.ToString();
        }
    }
}