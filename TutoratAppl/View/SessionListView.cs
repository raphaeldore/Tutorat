using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class SessionListView
    {
        IEnumerable<SessionListVM> Sessions;

        public SessionListView(IEnumerable<SessionListVM> _Sessions)
        {
            Sessions = _Sessions;
        }

        public void Display()
        {
            foreach (SessionListVM s in Sessions)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}