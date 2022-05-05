using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Vehicle
{
   public abstract class Vehicle
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int MaxSpeed;
        public string brand
        {
            get
            {
                return Brand;
            }
            set
            {
                if ( string.IsNullOrWhiteSpace(value))
                {
                    Brand = value;
                }
                else
                {                  
                    Console.WriteLine("The name of the vehicle must be specified ");
                }
            }
        }
        public string model         
        {
            get
            {
                return Model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Model = value;
                }
                else
                {                   
                    Console.WriteLine("The name of the model must be specified");
                }
        }   }
        public Vehicle()
        {
            Console.WriteLine("Car Created");
        }
        public Vehicle(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }
        public Vehicle(string brand, string model, string colour, ushort maxSpeed):this(brand,model)
        {
            Colour = colour;
            MaxSpeed = maxSpeed;
        }
        public abstract string Info();       
    }
}
