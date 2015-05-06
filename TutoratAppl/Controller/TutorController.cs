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
        private IEntityRepository<Entity> IEntityRepository;

        public TutorController(IEntityRepository<Entity> _IEntityRepository)
        {
            this.IEntityRepository = _IEntityRepository;
        }

        public void ListAll()
        {
            //Imprimer le nom, prénom, courriel, total heures tutorat, passéess et à venir, réalisées et planifiées
            //TODO: À mapper manuellement?
            List<TutorListVM> tutorList = new List<TutorListVM>();
            TutorListVM currentTutor;

            foreach(Tutor t in IEntityRepository.GetAll())
            {
                currentTutor = new TutorListVM();
                currentTutor.EmailAddress = t.EmailAddress;
                currentTutor.FirstName = t.FirstName;
                currentTutor.LastName = t.LastName;
                currentTutor.ID = t.Id;
            }

            TutorListView display = new TutorListView(tutorList);
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