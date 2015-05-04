using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.View
{
    public class TutorListView
    {
        IEnumerable<TutorsListVM> Tutors;

        public TutorListView(IEnumerable<TutorsListVM> _Tutors)
        {
            Tutors = _Tutors;
        }

        public void Display()
        {
            Console.WriteLine("TODO: Implement TutorListView display");
        }
    }
}