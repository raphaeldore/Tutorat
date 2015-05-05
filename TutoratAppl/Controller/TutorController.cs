using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.View;

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
            TutorListView affichage = new TutorListView(IEntityRepository.GetAll().ToList());
            affichage.Display();
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