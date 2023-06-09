﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClasses
{
    public class Museum
    {
        private int id;
        private float price;
        private string name;
        private string location;
        private string phoneNumber;
        private TimeSpan openTime;
        private TimeSpan closeTime;

        public int ID { get => id; set => id = value; }
        public float Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public TimeSpan OpenTime { get => openTime; set => openTime = value; }
        public TimeSpan CloseTime { get => closeTime; set => closeTime = value; }

        public Museum(float price, string name, string location, string phoneNumber, TimeSpan openTime, TimeSpan closeTime)
        {
            this.Price = price;
            this.Name = name;
            this.Location = location;
            this.PhoneNumber = phoneNumber;
            this.OpenTime = openTime;
            this.CloseTime = closeTime;
        }
        public Museum()
        {

        }
    }
}
