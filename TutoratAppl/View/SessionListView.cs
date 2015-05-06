using System;
using System.Collections.Generic;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class SessionListView
    {
        private IEnumerable<SessionListVM> Sessions;

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