/*
Read 3 floating-point numbers. After, print the roots of bhaskara’s formula. If it's impossible to calculate the roots because a division by zero or a square root of a negative number, presents the message “Impossivel calcular”.

Input
Read 3 floating-point numbers (double) A, B and C.

Output
Print the result with 5 digits after the decimal point or the message if it is impossible to calculate.
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace urionlinejudge {
    class Example1036 {
        static void Main(string[] args) {
            double A, B, C, delta, R1, R2;
            string[] values = Console.ReadLine().Split(' ');
            A = double.Parse(values[0], CultureInfo.InvariantCulture);
            B = double.Parse(values[1], CultureInfo.InvariantCulture);
            C = double.Parse(values[2], CultureInfo.InvariantCulture);
            delta = B * B - 4.0 * A * C;
            if (A == 0.0 || delta < 0.0) {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

                Console.WriteLine($"R1 = {R1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {R2.ToString("F5", CultureInfo.InvariantCulture)}");

            }
        }
    }
}
