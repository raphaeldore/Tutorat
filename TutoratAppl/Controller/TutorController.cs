using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            //Manual mapping
            //List<TutorListVM> tutorList = new List<TutorListVM>();
            //TutorListVM currentTutor;
            //foreach(Tutor t in IEntityRepository.GetAll())
            //{
            //    currentTutor = new TutorListVM();
            //    currentTutor.EmailAddress = t.EmailAddress;
            //    currentTutor.FirstName = t.FirstName;
            //    currentTutor.LastName = t.LastName;
            //    currentTutor.ID = t.Id;
            //}
            //TutorListView display = new TutorListView(tutorList);

            var list = IEntityRepository.GetAll().Select(s => new TutorListVM { Id = s.Id, LastName = s.LastName, FirstName = s.FirstName, EmailAddress = s.EmailAddress });
            TutorListView display = new TutorListView(list);

            display.Display();
        }

        public void ListAllWithWorkingHoursTotal()
        {
        
        }

        public void ListWhenNextTutoringSession()
        {
        
        }

        public void ListWhenWithoutTutoringSession(DateTime sessionDate)
        {
            
        }
    }
}