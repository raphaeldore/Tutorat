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
            var list = IEntityRepository.GetAll().Select(s => new TutorListVM { Id = s.Id, LastName = s.LastName, FirstName = s.FirstName, EmailAddress = s.EmailAddress });
            TutorListView affichage = new TutorListView(list);
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