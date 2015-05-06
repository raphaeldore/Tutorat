using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using DataLayer.Model;
using TutoratAppl.ViewModel;
using TutoratAppl.View;

namespace TutoratAppl.Controller
{
    public class TutoringSessionController
    {
        private readonly IEntityRepository<TutoringSession> IEntityRepository;

        public TutoringSessionController(IEntityRepository<TutoringSession> _IEntityRepository)
        {
            this.IEntityRepository = _IEntityRepository;
        }

        public void ListAll()
        {
            var list = IEntityRepository.GetAll().Select(s => 
                new SessionListVM { 
                    Id = s.Id, 
                    DateTimeSession = s.DateSession,
                    HelpedFirstName = s.helpedStudent.FirstName,
                    HelpedLastName = s.helpedStudent.LastName, 
                    SessionLenght = s.LenghtSession, 
                    TutorFirstName = s.tutor.FirstName, 
                    TutorLastName = s.tutor.LastName 
                });

            SessionListView display = new SessionListView(list);

            display.Display();
        }

        public void listAllFutureTutorTutoringSessions()
        {
            DateTime currentDate = DateTime.Now.Date;

            var list = IEntityRepository.GetAll().Where(s =>
                s.DateSession.Year >= currentDate.Year
                && s.DateSession.Month >= currentDate.Month
                && s.DateSession.Day >= currentDate.Day
                && s.DateSession.Hour > currentDate.Hour).Select(ts =>
                    new SessionListVM
                    {
                        DateTimeSession = ts.DateSession,
                        HelpedFirstName = ts.helpedStudent.FirstName,
                        HelpedLastName = ts.helpedStudent.LastName,
                        Id = ts.Id,
                        SessionLenght = ts.LenghtSession,
                        TutorFirstName = ts.tutor.FirstName,
                        TutorLastName = ts.tutor.LastName
                    }).OrderBy(tl => tl.TutorLastName).ThenBy(tf => tf.TutorLastName).ThenBy(ds => ds.DateTimeSession);

            SessionListView display = new SessionListView(list);
            display.Display();
        }
    }
}