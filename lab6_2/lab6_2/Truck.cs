using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    class Truck : ITrans
    {

        private String brand, number, maxSpeed;
        private int loadCapacity;
        private bool trailer;

        public Truck(String brand, String number, String maxSpeed, int loadCapacity, bool trailer)
        {
            this.brand = brand;
            this.number = number;
            this.maxSpeed = maxSpeed;
            this.loadCapacity = loadCapacity;
            this.trailer = trailer;
        }

        public int getLoadCapacity()
        {
            return trailer == true ? loadCapacity * 2 : loadCapacity;
        }

        public void printInformation()
        {
            Console.WriteLine("Brand: " + brand + "\n" + "Number: " + number + "\n" + "Max Speed: " + maxSpeed + "\n" + "Load capacity: " + getLoadCapacity() + "\n" + "Trailer presence: " + trailer + "\n");
        }
    }
}
