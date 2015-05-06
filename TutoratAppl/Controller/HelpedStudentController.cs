using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using DataLayer.Model;
using TutoratAppl.View;
using TutoratAppl.ViewModel;

namespace TutoratAppl.Controller
{
    public class HelpedStudentController
    {
        private readonly IEntityRepository<HelpedStudent> IEntityRepository;

        public HelpedStudentController(IEntityRepository<HelpedStudent> _IEntityRepository)
        {
            this.IEntityRepository = _IEntityRepository;
        }

        public void ListAll()
        {
            var list = IEntityRepository.GetAll().Select(s => new HelpedListVM { Id = s.Id, LastName = s.LastName, FirstName = s.FirstName, EmailAddress = s.EmailAddress });
            HelpedListView display = new HelpedListView(list);

            display.Display();
        }

        public void ListWhenWithoutTutoringSession()
        {
            
        }
    }
}