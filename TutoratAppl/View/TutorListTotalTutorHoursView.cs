﻿using System;
using System.Collections.Generic;
using TutoratAppl.ViewModel;

namespace TutoratAppl.View
{
    public class TutorListTotalTutorHoursView
    {
        private IEnumerable<TutorListTotalTutorHoursVM> Tutors;

        public TutorListTotalTutorHoursView(IEnumerable<TutorListTotalTutorHoursVM> _Tutors)
        {
            Tutors = _Tutors;
        }

        public void Display()
        {
            foreach (TutorListTotalTutorHoursVM t in Tutors)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}