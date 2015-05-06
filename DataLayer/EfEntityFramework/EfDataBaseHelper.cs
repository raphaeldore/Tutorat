using DataLayer.Model;
using System;

namespace DataLayer.EfEntityFramework
{
    public class EfDataBaseHelper
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
            DeleteAll();
            PopulateTable();
        }

        private void PopulateTable()
        {
            Tutor t_gBilodeau = new Tutor { LastName = "Bilodeau", FirstName = "Gary", EmailAddress = "bgary007@exemple.com" };
            Tutor t_sGagnon = new Tutor { LastName = "Gagnon", FirstName = "Samuel", EmailAddress = "samganon@videotron.com" };
            Tutor t_sGingras = new Tutor { LastName = "Gingras", FirstName = "Simon", EmailAddress = "sgingras@bell.ca" };
            Tutor t_eRoy = new Tutor { LastName = "Roy", FirstName = "Éric", EmailAddress = "ericleroy@hotmail.com" };
            Tutor t_cVeilleux = new Tutor { LastName = "Veilleux", FirstName = "Caroline", EmailAddress = "caroveilleux@gmail.com" };
            Tutor t_kTremblay = new Tutor { LastName = "Tremblay", FirstName = "Karine", EmailAddress = "karinelalatremblay@hellokitty.com" };
            Tutor t_lVezina = new Tutor { LastName = "Vézina", FirstName = "Louis", EmailAddress = "pasletrophevezina@gmail.com" };

            tutorRepository.Add(t_gBilodeau);
            tutorRepository.Add(t_sGagnon);
            tutorRepository.Add(t_sGingras);
            tutorRepository.Add(t_eRoy);
            tutorRepository.Add(t_cVeilleux);
            tutorRepository.Add(t_kTremblay);
            tutorRepository.Add(t_lVezina);

            HelpedStudent hs_mArsenault = new HelpedStudent { LastName = "Arsenault", FirstName = "Marc", EmailAddress = "marcarsenault@fastmail.com" };
            HelpedStudent hs_eBoilard = new HelpedStudent { LastName = "Boilard", FirstName = "Éric", EmailAddress = "ericboilard@hotmail.com" };
            HelpedStudent hs_jcCouture = new HelpedStudent { LastName = "Couture", FirstName = "Jean-Cristophe", EmailAddress = "jc@gmail.com" };
            HelpedStudent hs_jDesrosiers = new HelpedStudent { LastName = "Desrosiers", FirstName = "Julianne", EmailAddress = "desrosiersj@fastmail.com" };
            HelpedStudent hs_lGregoireAllen = new HelpedStudent { LastName = "Grégoire-Allen", FirstName = "Léa", EmailAddress = "leogreg@hotmail.com" };
            HelpedStudent hs_fHamel = new HelpedStudent { LastName = "Hamel", FirstName = "François", EmailAddress = "fhamel@fastmail.com" };
            HelpedStudent hs_jLepage = new HelpedStudent { LastName = "Lepage", FirstName = "Jérémy", EmailAddress = "jeremylepage@gmail.com" };
            HelpedStudent hs_nPoitras = new HelpedStudent { LastName = "Poitras", FirstName = "Nicolas", EmailAddress = "npoitras@fastmail.com" };
            HelpedStudent hs_sRoyGagnon  = new HelpedStudent { LastName = "Roy-Gagnon", FirstName = "Samuel", EmailAddress = "samleroy@gmail.com" };
            HelpedStudent hs_bSimard = new HelpedStudent { LastName = "Simard", FirstName = "Benjamin", EmailAddress = "benjaminsimard@fastmail.com" };
            HelpedStudent hs_sVachon = new HelpedStudent { LastName = "Vachon", FirstName = "Samuel", EmailAddress = "samvachon@hotmail.com" };

            helpedStudentRepository.Add(hs_mArsenault);
            helpedStudentRepository.Add(hs_eBoilard);
            helpedStudentRepository.Add(hs_jcCouture);
            helpedStudentRepository.Add(hs_jDesrosiers);
            helpedStudentRepository.Add(hs_lGregoireAllen);
            helpedStudentRepository.Add(hs_fHamel);
            helpedStudentRepository.Add(hs_jLepage);
            helpedStudentRepository.Add(hs_nPoitras);
            helpedStudentRepository.Add(hs_sRoyGagnon);
            helpedStudentRepository.Add(hs_bSimard);
            helpedStudentRepository.Add(hs_sVachon);

            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 3, 16, 13, 0, 0), 2, hs_lGregoireAllen, t_cVeilleux));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 3, 24, 10, 0, 0), 1, hs_lGregoireAllen, t_gBilodeau));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 3, 25, 13, 0, 0), 1, hs_eBoilard, t_eRoy));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 4, 1, 12, 0, 0), 2, hs_mArsenault, t_cVeilleux));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 4, 1, 13, 0, 0), 1, hs_eBoilard, t_sGingras));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 4, 6, 16, 0, 0), 1, hs_mArsenault, t_eRoy));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 4, 8, 10, 0, 0), 1, hs_fHamel, t_eRoy));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 4, 10, 13, 0, 0), 2, hs_mArsenault, t_eRoy));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 4, 29, 12, 0, 0), 1, hs_sRoyGagnon, t_cVeilleux));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 5, 25, 13, 0, 0), 1, hs_bSimard, t_lVezina));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 5, 27, 12, 0, 0), 2, hs_bSimard, t_cVeilleux));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 5, 27, 13, 0, 0), 1, hs_eBoilard, t_sGingras));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 6, 1, 9, 0, 0), 1, hs_jLepage, t_lVezina));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 6, 2, 9, 0, 0), 1, hs_sVachon, t_lVezina));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 6, 2, 11, 0, 0), 1, hs_eBoilard, t_lVezina));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 6, 2, 13, 0, 0), 1, hs_lGregoireAllen, t_gBilodeau));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 6, 2, 15, 0, 0), 1, hs_sRoyGagnon, t_eRoy));
            tutoringSessionRepository.Add(CreateTutoringSession(new DateTime(2015, 6, 3, 13, 0, 0), 2, hs_jLepage, t_sGingras));
        }

        private TutoringSession CreateTutoringSession(DateTime dateSession, int lenghtSession, HelpedStudent helpedStudent, Tutor tutor) {
            return new TutoringSession{DateSession = dateSession, LenghtSession = lenghtSession, HelpedStudentId = helpedStudent.Id, TutorId = tutor.Id};
        }

        private void DeleteAll()
        {
            tutoringSessionRepository.DeleteAll();
            helpedStudentRepository.DeleteAll();
            tutorRepository.DeleteAll();
        }
    }
}