using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Taxi Taxi = new Taxi();

            Taxi.DriverName = "Jono";
            Taxi.OnDuty = true;
            Taxi.Number = 10;

            Taxi.TaxiInfo();
            Taxi.PickUpPassenger();
            Taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
