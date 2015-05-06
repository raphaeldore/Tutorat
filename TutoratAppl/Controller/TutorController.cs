using DataLayer;
using DataLayer.Model;
using System;
using System.Linq;
using TutoratAppl.View;
using TutoratAppl.ViewModel;

namespace TutoratAppl.Controller
{
    public class TutorController
    {
        private IEntityRepository<Tutor> IEntityRepository;

        public TutorController(IEntityRepository<Tutor> _IEntityRepository)
        {
            this.IEntityRepository = _IEntityRepository;
        }

        public void ListAll()
        {
            //Imprimer le nom, prénom, courriel, total heures tutorat, passéess et à venir, réalisées et planifiées

            var tutorList = IEntityRepository.GetAll().Select(
                s => new TutorListVM
                {
                    Id = s.Id,
                    LastName = s.LastName,
                    FirstName = s.FirstName,
                    EmailAddress = s.EmailAddress
                });

            TutorListView display = new TutorListView(tutorList);
            display.Display();
        }

        public void ListAllWithWorkingHoursTotal()
        {
            var tutorList = IEntityRepository.GetAll().Select(s =>
                new TutorListTotalTutorHoursVM
                {
                    LastName = s.LastName,
                    FirstName = s.FirstName,
                    EmailAddress = s.EmailAddress,
                    TotalTutoringHours = s.tutoringSessions.Sum(x => (int?)x.LenghtSession) ?? 0
                });

            TutorListTotalTutorHoursView display = new TutorListTotalTutorHoursView(tutorList);

            display.Display();
        }

        public void listAllFreeTutorOnDate(DateTime dateTime)
        {
            // Liste des tuteurs qui n'ont aucune rencontre à un certain jour
            var tutorList = IEntityRepository.GetAll().Where(t =>
                !t.tutoringSessions.Any(x =>
                    x.DateSession.Year == dateTime.Year
                    && x.DateSession.Month == dateTime.Month
                    && x.DateSession.Day == dateTime.Day)).Select(tu =>
                        new TutorListVM
                        {
                            Id = tu.Id,
                            LastName = tu.LastName,
                            FirstName = tu.FirstName,
                            EmailAddress = tu.EmailAddress
                        });

            TutorListView display = new TutorListView(tutorList);
            display.Display();
        }
    }
}