using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.Controller
{
    public class TutorController
    {
        private IEntityRepository<Entity> IEntityRepository;

        public TutorController(IEntityRepository<Entity> _IEntityRepository)
        {
            this.IEntityRepository = _IEntityRepository;
        }

    }
}