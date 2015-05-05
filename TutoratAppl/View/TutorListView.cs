using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class TutorListView
    {
        private IEnumerable<TutorListVM> Tutors;

        public TutorListView(IEnumerable<TutorListVM> _Tutors)
        {
            Tutors = _Tutors;
        }

        public void Display()
        {
            foreach(TutorListVM t in Tutors)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}