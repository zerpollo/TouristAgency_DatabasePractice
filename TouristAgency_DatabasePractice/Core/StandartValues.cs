using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency_DatabasePractice.Core
{
    public class StandartValues
    {
        public static List<TimeSpan> timeOptions = new List<TimeSpan>()
        {
             new TimeSpan(8,0,0),
             new TimeSpan(9,0,0),
             new TimeSpan(10,0,0),
             new TimeSpan(11,0,0),
             new TimeSpan(12,0,0),
             new TimeSpan(13,0,0),
             new TimeSpan(14,0,0),
             new TimeSpan(15,0,0),
             new TimeSpan(16,0,0),
             new TimeSpan(17,0,0),
             new TimeSpan(18,0,0),
             new TimeSpan(19,0,0),
             new TimeSpan(20,0,0),
        };

        public static List<int> NumberOfPeople = new List<int>()
        {
            1,
            2,
            3,
            4,
            5
        };

    }
}
