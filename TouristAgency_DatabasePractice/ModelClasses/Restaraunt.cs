using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Restaraunt
    {
        private int id;
        private string name;
        private string phoneNumber;
        private string location;
        private string description;
        private TimeOnly openTime;
        private TimeOnly closeTime;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Location { get => location; set => location = value; }
        public string Description { get => description; set => description = value; }
        public TimeOnly OpenTime { get => openTime; set => openTime = value; }
        public TimeOnly CloseTime { get => closeTime; set => closeTime = value; }

        public Restaraunt(string name, string phoneNumber, string location, string description, TimeOnly openTime, TimeOnly closeTime)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Location = location;
            this.Description = description;
            this.OpenTime = openTime;
            this.CloseTime = closeTime;
        }
        public Restaraunt()
        {

        }
    }
}
