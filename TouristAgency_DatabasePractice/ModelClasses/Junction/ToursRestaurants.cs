using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency_DatabasePractice.ModelClasses.Junction
{
    public class ToursRestaurants
    {
        private int id;
        private int tourID;
        private int restaurantID;

        public int Id { get => id; set => id = value; }
        public int TourID { get => tourID; set => tourID = value; }
        public int RestaurantID { get => restaurantID; set => restaurantID = value; }

        public ToursRestaurants(int id, int tourID, int restaurantID)
        {
            this.id = id;
            this.tourID = tourID;
            this.restaurantID = restaurantID;
        }

        public ToursRestaurants()
        {

        }
    }
}
