using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency_DatabasePractice.ModelClasses.Junction
{
    public class ActivitiesDateTime
    {
        private int id;
        private int dateTimeID;
        private int activityID;

        public int Id { get => id; set => id = value; }
        public int DateTimeID { get => dateTimeID; set => dateTimeID = value; }
        public int ActivityID { get => activityID; set => activityID = value; }

        public ActivitiesDateTime(int id, int dateTimeID, int activityID)
        {
            this.id = id;
            this.dateTimeID = dateTimeID;
            this.activityID = activityID;
        }

        public ActivitiesDateTime()
        {

        }
    }
}
