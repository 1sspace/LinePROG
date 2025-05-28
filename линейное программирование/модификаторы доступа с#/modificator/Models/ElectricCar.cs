using System;

namespace MyApp.Models
{
    public class ElectricCar : Car
    {
        private double batteryCapacity;

        public void SetBatteryCapacity(double capacity)
        {
            batteryCapacity = capacity;
        }

        public void ShowInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Ёмкость батареи: {batteryCapacity} кВт·ч");
        }
    }
}