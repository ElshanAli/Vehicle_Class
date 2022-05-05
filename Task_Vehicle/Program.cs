using System;

namespace Task_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {          
            Bus bus = new Bus("Mercedes","Viano ","Green",120,30);
            if (string.IsNullOrEmpty(bus.Brand)||string.IsNullOrWhiteSpace(bus.Brand)||string.IsNullOrEmpty(bus.Model)||string.IsNullOrWhiteSpace(bus.Model))
            {
                
            }
            else
            {
                Bus bus1 = new Bus();
            }
            Console.WriteLine(bus.Info());
            Console.WriteLine("-------------------------------------------------------------");
            Bus bus2 = new Bus("Mercedes", "Spirinter ", "Orange", 130, 40);

            if (string.IsNullOrEmpty(bus.Brand) || string.IsNullOrWhiteSpace(bus.Brand) || string.IsNullOrEmpty(bus.Model) || string.IsNullOrWhiteSpace(bus.Model))
            {
                Console.WriteLine("Car wasn'n created");
            }
            else
            {
                Bus bus1 = new Bus();
            }
            Console.WriteLine(bus2.Info());
        }
    }
}
