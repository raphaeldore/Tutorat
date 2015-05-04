using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using DataLayer.Model;

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
            
        }

        public void ListWhenWithoutTutoringSession()
        {
            
        }
    }
}