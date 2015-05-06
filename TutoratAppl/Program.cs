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
            EfDataBaseHelper helper = new EfDataBaseHelper();
            helper.SeedDatabase();
 
            TutorController tutorController = new TutorController(new EfEntityRepository<Tutor>());
            tutorController.ListAll();

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();

            HelpedStudentController helpStudentController = new HelpedStudentController(new EfEntityRepository<HelpedStudent>());
            helpStudentController.ListAll();

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();

            TutoringSessionController tutoringSessionController = new TutoringSessionController(new EfEntityRepository<TutoringSession>());
            tutoringSessionController.ListAll();

            Console.WriteLine("Appuyez sur une touche pour quitter. ");
            Console.ReadKey();
        }
    }
}
