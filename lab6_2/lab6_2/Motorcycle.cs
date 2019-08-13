using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    class Motorcycle : ITrans
    {
        private String brand, number, maxSpeed;
        private int loadCapacity;
        private bool carriage;

        public Motorcycle(String brand, String number, String maxSpeed, int loadCapacity, bool carriage)
        {
            this.brand = brand;
            this.number = number;
            this.maxSpeed = maxSpeed;
            this.loadCapacity = loadCapacity;
            this.carriage = carriage;
        }

        public int getLoadCapacity()
        {
            return carriage == true ? loadCapacity : 0;
        }

        public void printInformation()
        {
            Console.WriteLine("Brand: " + brand + "\n" + "Number: " + number + "\n" + "Max Speed: " + maxSpeed + "\n" + "Load capacity: " + getLoadCapacity() + "\n" + "Carriage presence: " + carriage + "\n");

        }
    }
}
