using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    class PassengerCar : ITrans
    {

        private String brand, number, maxSpeed;
        private int loadCapacity;

        public PassengerCar(String brand, String number, String maxSpeed, int loadCapacity)
        {
            this.brand = brand;
            this.number = number;
            this.maxSpeed = maxSpeed;
            this.loadCapacity = loadCapacity;
        }

        public int getLoadCapacity()
        {
            return loadCapacity;
        }

        public void printInformation()
        {
            Console.WriteLine("Brand: " + brand + "\n" + "Number: " + number + "\n" + "Max Speed: " + maxSpeed + "\n" + "Load capacity: " + getLoadCapacity() + "\n");
        }
    }
}
