using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoratAppl.View
{
    class TutorListView
    {
        IEnumerable<Tutors> Tutors;

        public TutorListView(IEnumerable<Tutors> _Tutors)
        {
            Tutors = _Tutors;
        }
    }
}