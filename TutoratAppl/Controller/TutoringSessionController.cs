using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using DataLayer.Model;

namespace TutoratAppl.Controller
{
    class TutoringSessionController
    {
        private readonly IEntityRepository<HelpedStudent> IEntityRepository;

        public TutoringSessionController(IEntityRepository<HelpedStudent> _IEntityRepository)
        {
            this.IEntityRepository = _IEntityRepository;
        }

        public void ListAll()
        {
            
        }

    }
}
