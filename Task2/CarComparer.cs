using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task2
{
    internal class CarComparer : IComparer<Car>
    {
        public int Compare([AllowNull] Car x, [AllowNull] Car y)
        {
            throw new NotImplementedException();
        }

        public class compate_by_Name : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                if (x.Name.CompareTo(y.Name) == 1) return 1;
                else return -1;
            }
        }
        public class compate_by_year : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return Convert.ToInt16(x.Production_Year < y.Production_Year);
            }
        }
        public class compate_by_speed : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return Convert.ToInt16(x.Max_Speed < y.Max_Speed);
            }
        }
     
    }
}
