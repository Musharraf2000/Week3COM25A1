using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3COM25A1
{
    internal class Coffeemachine
    {
        private string brand;
        private double maxCapacity;
        private double waterLevel;

        public Coffeemachine(string brand, double maxCapacity)
        {
            this.brand = brand;
            this.maxCapacity = maxCapacity;
            waterLevel = 0;
        }

        public string Brand { get => brand; set => brand = value; }
        public double MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
        public double WaterLevel { get => waterLevel; set => waterLevel = value; }


        public void Addwater(double amount) {
            waterLevel += amount;

            if (waterLevel > maxCapacity)
            {
                waterLevel = maxCapacity;
                Console.WriteLine("Cannot add that much water. Max Capacity Reached");
            }
            else
            {
                Console.WriteLine("Water added");
            }
        
        }
        public void MakeCoffee(double requiredWater)
        {
            if(requiredWater <= waterLevel)
            {
                Console.WriteLine("Coffee made successfully");
                waterLevel -= requiredWater;
            }
            else
            {
                Console.WriteLine("Insufficient water level");
            }
        }

        public void CheckStatus()
        {
            Console.WriteLine($"Brand : {brand} Capacity : {MaxCapacity}  Water Level : {WaterLevel}");
        }
    }
}
