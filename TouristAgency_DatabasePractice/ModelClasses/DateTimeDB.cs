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
        private DateTime dateTime;

        public int ID { get => id; set => id = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public DateTimeDB(DateTime datetime)
        {
            this.dateTime = datetime;
        } 
        public DateTimeDB()
        {

        }
    }
}
