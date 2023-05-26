using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency_DatabasePractice.ModelClasses.Junction
{
    internal class ToursShops
    {
        private int id;
        private int tourID;
        private int shopID;

        public int ID { get => id; set => id = value; }
        public int TourID { get => tourID; set => tourID = value; }
        public int ShopID { get => shopID; set => shopID = value; }

        public ToursShops(int tourID, int shopID)
        {
            this.tourID = tourID;
            this.shopID = shopID;
        }

        public ToursShops()
        {

        }
    }
}
