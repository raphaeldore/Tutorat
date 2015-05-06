using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class HelpedStudentListView
    {
        IEnumerable<HelpedStudentListVM> HelpedStudents;

        public HelpedStudentListView(IEnumerable<HelpedStudentListVM> _HelpedStudents)
        {
            HelpedStudents = _HelpedStudents;
        }

        public void Display()
        {
            foreach (HelpedStudentListVM h in HelpedStudents)
            {
                Console.WriteLine(h.ToString());
            }
        }
    }
}