﻿using System;

namespace MyApp.Models
{
    public class Car
    {
        private string make;
        private string model;

        public int Year { get; set; }

        internal void SetMakeAndModel(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        protected virtual void DisplayInfo()
        {
            Console.WriteLine($"Марка: {make}, Модель: {model}, Год: {Year}");
        }
    }
}