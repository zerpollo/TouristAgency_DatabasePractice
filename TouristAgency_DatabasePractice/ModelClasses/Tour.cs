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
        private DateTime issuanceDate;

        public int ID { get => id; set => id = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int Price { get => price; set => price = value; }
        public DateTime IssuanceDate { get => issuanceDate; set => issuanceDate = value; }

        public Tour(int clientID, int price, DateTime issuanceDate)
        {
            this.ClientID = clientID;
            this.Price = price;
            this.IssuanceDate = issuanceDate;
        }
        public Tour()
        {

        }
    }
}
