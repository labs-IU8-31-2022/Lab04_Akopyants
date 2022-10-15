using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> CARS = new List<Car>();

            Car car = new Car("Honda", 1994, 240);
            Car car1 = new Car("Mercedes", 2012, 250);
            Car car2 = new Car("BMW", 1984, 180);

            CARS.Add(car);
            CARS.Add(car1);
            CARS.Add(car2);
            
           CARS.Sort(new CarComparer.compate_by_year());
            foreach(var el in CARS)
            {
                Console.WriteLine($"Name - {el.Name}; Year - {el.Production_Year}; Max Speed - {el.Max_Speed};\n");
            }
            
        }
    }
}