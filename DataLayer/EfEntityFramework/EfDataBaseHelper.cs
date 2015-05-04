using DataLayer.Model;
using System;

namespace DataLayer.EfEntityFramework
{
    internal class EfDataBaseHelper
    {
        private EfEntityRepository<Tutor> tutorRepository;
        private EfEntityRepository<HelpedStudent> helpedStudentRepository;
        private EfEntityRepository<TutoringSession> tutoringSessionRepository;

        public EfDataBaseHelper()
        {
            tutorRepository = new EfEntityRepository<Tutor>();
            helpedStudentRepository = new EfEntityRepository<HelpedStudent>();
            tutoringSessionRepository = new EfEntityRepository<TutoringSession>();
        }

        public void SeedDatabase()
        {
            AddTutors();
            AddHelpedStudents();
            AddTutoringSessions();
        }

        private void AddTutors()
        {
            tutorRepository.Add(new Tutor { LastName = "Bilodeau", FirstName = "Gary", EmailAddress = "bgary007@exemple.com" });
            tutorRepository.Add(new Tutor { LastName = "Gagnon", FirstName = "Samuel", EmailAddress = "samganon@videotron.com" });
            tutorRepository.Add(new Tutor { LastName = "Gingras", FirstName = "Simon", EmailAddress = "sgingras@bell.ca" });
            tutorRepository.Add(new Tutor { LastName = "Roy", FirstName = "Éric", EmailAddress = "ericleroy@hotmail.com" });
            tutorRepository.Add(new Tutor { LastName = "Veilleux", FirstName = "Caroline", EmailAddress = "caroveilleux@gmail.com" });
            tutorRepository.Add(new Tutor { LastName = "Karine", FirstName = "Tremblay", EmailAddress = "karinelalatremblay@hellokitty.com" });
            tutorRepository.Add(new Tutor { LastName = "Louis", FirstName = "Vézina", EmailAddress = "pasletrophevezina@gmail.com" });
        }

        private void AddHelpedStudents()
        {
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Arsenault", FirstName = "Marc", EmailAddress = "marcarsenault@fastmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Boilard", FirstName = "Éric", EmailAddress = "ericboilard@hotmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Couture", FirstName = "Jean-Cristophe", EmailAddress = "jc@gmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Desrosiers", FirstName = "Julianne", EmailAddress = "desrosiersj@fastmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Grégoire-Allen", FirstName = "Léa", EmailAddress = "leogreg@hotmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Hamel", FirstName = "François", EmailAddress = "fhamel@fastmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Lepage", FirstName = "Jérémy", EmailAddress = "jeremylepage@gmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Poitras", FirstName = "Nicolas", EmailAddress = "npoitras@fastmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Roy-Gagnon", FirstName = "Samuel", EmailAddress = "samleroy@gmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Simard", FirstName = "Benjamin", EmailAddress = "benjaminsimard@fastmail.com" });
            helpedStudentRepository.Add(new HelpedStudent { LastName = "Vachon", FirstName = "Samuel", EmailAddress = "samvachon@hotmail.com" });
        }

        private void AddTutoringSessions()
        {
            DateTime date = new DateTime(;

            //tutoringSessionRepository.Add(new TutoringSession{DateSession = new DateTime(2015, 3, 16, 13), LenghtSession = 2, HelpedId = helpedStudentRepository.GetAll()})
        }

        private void DeleteAll()
        {
            foreach (var tutoringSession in tutoringSessionRepository.GetAll())
            {
                tutoringSessionRepository.Delete(tutoringSession);
            }

            foreach (var helpedStudent in helpedStudentRepository.GetAll())
            {
                helpedStudentRepository.Delete(helpedStudent);
            }

            foreach (var tutor in tutorRepository.GetAll())
            {
                tutorRepository.Delete(tutor);
            }
        }
    }
}