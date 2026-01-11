using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SecondProgram {
     class  MathFunctions {

        static void Main(string[] args) {

            double x = 3.0;
            double y = 4.0;  
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine($"Square Root of {x} is equal {A.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Square Root of {y} is equal {B}");
            Console.WriteLine($"Square Root of 25 is equal {C}");

            A = Math.Pow(x,y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine($"{x} raised to the power of {y} equals {A}");
            Console.WriteLine($"{x} raised to the power of 2.0 equals {B}");
            Console.WriteLine($"5.0 squared equals {C}");

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine($"Absolute value of {y} is equal {A}");
            Console.WriteLine($"Absolute value of {z} is equal {B}");

        }

    }
}
