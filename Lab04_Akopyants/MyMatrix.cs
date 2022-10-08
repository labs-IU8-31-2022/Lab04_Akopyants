using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Akopyants
{
    class MyMatrix
    {
        public MyMatrix()
        {}
        public MyMatrix(uint _m, uint _n, int range)
        {
            Random rand = new Random();
            for (int i = 0; i < _m; ++i)
            {
                for(int j = 0; j < _n; ++j)
                {
                    matrix[i,j] = rand.Next() % range;
                }
            }
        }
        public MyMatrix(uint _m, uint _n)
        {
            Random rand = new Random();
            for (int i = 0; i < _m; ++i)
            {
                for (int j = 0; j < _n; ++j)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public static MyMatrix operator +(MyMatrix obj1, MyMatrix obj2)
        {
            if (obj1.matrix.Length != obj2.matrix.Length)
            {
                throw new Exception("Length exeption");
            }
            MyMatrix output = new MyMatrix();
            for (uint i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    output.matrix[i, j] = obj1.matrix[i, j] + obj2.matrix[i, j];
                }
            }
            return output;
        }
        public static MyMatrix operator -(MyMatrix obj1, MyMatrix obj2)
        {
            if(obj1.matrix.Length != obj2.matrix.Length)
            {
                throw new Exception("Length exeption");
            }
            MyMatrix output = new MyMatrix();
            for (uint i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    output.matrix[i, j] = obj1.matrix[i, j] - obj2.matrix[i, j];
                }
            }
            return output;
        }

        public static MyMatrix operator *(MyMatrix obj, int value)
        {
            MyMatrix output = new MyMatrix();
            for (uint i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    output.matrix[i, j] *= value;
                }
            }
            return output;
        }

        public static MyMatrix operator /(MyMatrix obj1, int value)
        {
            MyMatrix output = new MyMatrix();
            for (uint i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    output.matrix[i, j] /= value;
                }
            }
            return output;
        }

        public static MyMatrix operator *(MyMatrix obj1, MyMatrix obj2)
        {
            if (obj1.get_m() != obj2.get_n())
            {
                throw new Exception("In A x B multiplication" +
                    "A's columns quantity must be equal to B's rows quantity");
            }

            MyMatrix res = new MyMatrix(obj1.get_n(), obj2.get_m());
            for (int i = 0; i < obj1.get_n(); ++i)
            {
                for (int j = 0; j < obj2.get_m(); ++j)
                {
                    res.matrix[i, j] = 0;
                    for (int k = 0; k < obj1.get_m(); ++k)
                    {
                        for (int w = 0; w < obj2.get_n(); ++w)
                        {
                            res.matrix[i, j] += obj1.matrix[i, k] * obj2.matrix[w, j];
                        }
                    }
                }
            }

            return res;
        }

        public int this[uint value1, uint value2]
        {
            get => matrix[value1, value2];
            set { matrix[value1, value2] = value; } 

        }


        public uint get_m() => m;

        public uint get_n() => n;

        public void set_m(uint _m) => (m) = (_m);

        public void set_n(uint _n) => (n) = (_n);

        public static uint m;
        public static uint n;
        public int[,] matrix = new int[m,n];
    }
}
