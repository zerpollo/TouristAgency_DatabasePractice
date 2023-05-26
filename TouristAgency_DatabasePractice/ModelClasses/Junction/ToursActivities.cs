using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency_DatabasePractice.ModelClasses.Junction
{
    public class ToursActivities
    {
        private int id;
        private int tourID;
        private int activityID;

        public int Id { get => id; set => id = value; }
        public int TourID { get => tourID; set => tourID = value; }
        public int ActivityID { get => activityID; set => activityID = value; }

        public ToursActivities(int tourID, int activityID)
        {
            this.tourID = tourID;
            this.activityID = activityID;
        }

        public ToursActivities()
        {

        }

    }
}
