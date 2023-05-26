using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency_DatabasePractice.ModelClasses.Junction
{
    public class ToursMuseums
    {
        private int id;
        private int tourID;
        private int museumID;

        public int Id { get => id; set => id = value; }
        public int TourID { get => tourID; set => tourID = value; }
        public int MuseumID { get => museumID; set => museumID = value; }

        public ToursMuseums(int id, int tourID, int museumID)
        {
            this.id = id;
            this.tourID = tourID;
            this.museumID = museumID;
        }

        public ToursMuseums()
        {

        }
    }
}
