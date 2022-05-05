using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Vehicle
{
    class Bus:Vehicle
    {
        public byte PassengerCount;
        public Bus()
        {
        }
        public Bus(string brand, string model, string colour, ushort maxSpeed, byte passengerCount):base(brand,model,colour,maxSpeed)
        {
            PassengerCount = passengerCount;
        }
        public override string Info()
        {
            if (string.IsNullOrEmpty(brand)||string.IsNullOrWhiteSpace(brand)||string.IsNullOrEmpty(model)||string.IsNullOrWhiteSpace(model))
            {
                return $"Vehicle not found";
            }
            return $"Brand: {Brand} \nModel: {Model} \nColour: {Colour} \nMaxSpeed: {MaxSpeed} \nPassenger Count: {PassengerCount} ";
        }
    }
}
