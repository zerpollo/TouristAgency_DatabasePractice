﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Activity
    {
        private int id;
        private int duration;
        private int price;
        private string name;
        private string description;
        private string location;

        public int ID { get => id; set => id = value; }
        public int Duration { get => duration; set => duration = value; }
        public int Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Location { get => location; set => location = value; }

        public Activity(int dateTimeID, int languageID, int duration, int peopleQuantity, int price, string name, string description, string location)
        {
            this.duration = duration;
            this.price = price;
            this.name = name;
            this.description = description;
            this.location = location;
        }
        public Activity()
        {

        }
    }
}
