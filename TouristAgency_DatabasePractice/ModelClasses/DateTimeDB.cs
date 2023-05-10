using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class DateTimeDB
    {
        private int id;
        private DateOnly date;
        private TimeOnly time;

        public int ID { get => id; set => id = value; }
        public DateOnly Date { get => date; set => date = value; }
        public TimeOnly Time { get => time; set => time = value; }

        public DateTimeDB(DateOnly date, TimeOnly time)
        {
            this.Date = date;
            this.Time = time;
        } 
        public DateTimeDB()
        {

        }
    }
}
