using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList transports = new ArrayList();

            transports.Add(new Truck("ISUZU", "KZ66 ZYT", "140 km/h", 1500, true));
            transports.Add(new Truck("MERSEDES", "KK78 AZT", "150 km/h", 2000, false));
            transports.Add(new PassengerCar("OPEL", "ML45 LOD", "200 km/h", 500));
            transports.Add(new Motorcycle("SUZUKI", "KO33 EIT", "300 km/h", 100, false));
            transports.Add(new Motorcycle("BUCCATI", "LO25 LOK", "280 km/h", 100, true));

            foreach (ITrans transport in transports)
            {
                transport.printInformation();
            }

            Console.Write("\nEnter max load capacity: ");
            int minLoadCapacity = int.Parse(Console.ReadLine());

            foreach (ITrans transport in transports)
            {
                if (transport.getLoadCapacity() >= minLoadCapacity)
                {
                    transport.printInformation();
                    Console.ReadKey();
                }
            }
        }
    }
}
