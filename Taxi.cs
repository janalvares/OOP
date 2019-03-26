using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int Number { get; set; }

        

        public void TaxiInfo()
        {
            Console.WriteLine( "Driver Name : {0}", DriverName);
            Console.WriteLine( "On Duty : {0}", OnDuty ?"Yes" : "No");
            Console.WriteLine( "Number of Passenger : {0}\n", Number);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }
    }
}
