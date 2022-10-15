using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Car
    {
        public Car(string _name, uint _production_year, uint _max_speed) => (Name, Production_Year, Max_Speed) = (_name, _production_year, _max_speed);
       
        public string Name { get; set; }
        public uint Production_Year { get; set; }
        public uint Max_Speed { get; set; }

    }
}
