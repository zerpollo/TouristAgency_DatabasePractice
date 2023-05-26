using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency_DatabasePractice.ModelClasses.Junction
{
    public class LanguageActivities
    {
        private int id;
        private int languageID;
        private int activityID;

        public int Id { get => id; set => id = value; }
        public int LanguageID { get => languageID; set => languageID = value; }
        public int ActivityID { get => activityID; set => activityID = value; }

        public LanguageActivities(int languageID, int activityID)
        {
            this.languageID = languageID;
            this.activityID = activityID;
        }

        public LanguageActivities()
        {

        }
    }
}
