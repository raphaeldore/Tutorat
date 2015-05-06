using DataLayer.EfEntityFramework;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.Controller;

namespace TutoratAppl
{
    class Program
    {
        static void Main(string[] args)
        {            
            TutorController tutorController = new TutorController(new EfEntityRepository<Tutor>());
            tutorController.ListAll();

            HelpedStudentController helpStudentController = new HelpedStudentController(new EfEntityRepository<HelpedStudent>());
            helpStudentController.ListAll();

            TutoringSessionController tutoringSessionController = new TutoringSessionController(new EfEntityRepository<TutoringSession>());
            tutoringSessionController.ListAll();
        }
    }
}
