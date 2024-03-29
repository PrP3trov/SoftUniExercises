﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CarManufacturer
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive (double distance)
        {
            if (FuelQuantity - distance* fuelConsumption > 0)
            {
                FuelQuantity = FuelQuantity - distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform  this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {Make}\nModel:{Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}\n";
        }

    }
}
