using DataLayer;
using DataLayer.Model;
using System.Linq;
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
            var helpedStudentsList = IEntityRepository.GetAll().Select(s =>
                new HelpedStudentListVM
                {
                    Id = s.Id,
                    LastName = s.LastName,
                    FirstName = s.FirstName,
                    EmailAddress = s.EmailAddress
                });

            HelpedStudentListView display = new HelpedStudentListView(helpedStudentsList);

            display.Display();
        }

        public void ListHelpStudentsWithoutTutoringSession()
        {
            var helpedStudentsList = IEntityRepository.GetAll().Where(hs => hs.TutoringSessions.Count() == 0).Select(s =>
                new HelpedStudentListVM
                {
                    Id = s.Id,
                    LastName = s.LastName,
                    FirstName = s.FirstName,
                    EmailAddress = s.EmailAddress
                });

            HelpedStudentListView display = new HelpedStudentListView(helpedStudentsList);

            display.Display();
        }
    }
}