using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class HelpedListView
    {
        IEnumerable<HelpedListVM> HelpedStudents;

        public HelpedListView(IEnumerable<HelpedListVM> _HelpedStudents)
        {
            HelpedStudents = _HelpedStudents;
        }

        public void Display()
        {
            Console.WriteLine("TODO: Implement HelpedListView display");
        }
    }
}
