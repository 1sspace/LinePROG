using System;
using System.Runtime.ConstrainedExecution;
using MyApp.Models;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Year = 2010;
            car.SetMakeAndModel("toyota", "land cruiser");

            ElectricCar eCar = new ElectricCar();
            eCar.Year = 2022;
            eCar.SetMakeAndModel("tesla", "model x");
            eCar.SetBatteryCapacity(100.5);
            eCar.ShowInfo();

            Console.ReadLine();
        }
    }
}