using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Tour
    {
        private int id;
        private int clientID;
        private int price;
        private int peopleQuantity;
        private DateTime issuanceDate;

        public int ID { get => id; set => id = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int Price { get => price; set => price = value; }
        public DateTime IssuanceDate { get => issuanceDate; set => issuanceDate = value; }
        public int PeopleQuantity { get => peopleQuantity; set => peopleQuantity = value; }

        public Tour(int clientID, int price, DateTime issuanceDate, int peopleQuantity)
        {
            this.ClientID = clientID;
            this.Price = price;
            this.PeopleQuantity = peopleQuantity;
            this.IssuanceDate = issuanceDate;
        }
        public Tour()
        {

        }
    }
}
