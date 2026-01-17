/*
Read the four values corresponding to the x and y axes of two points in the plane, p1 (x1, y1) and p2 (x2, y2) and calculate the distance between them, showing four decimal places, according to the formula:

Distance = 

Input
The input file contains two lines of data. The first one contains two double values: x1 y1 and the second one also contains two double values with one digit after the decimal point: x2 y2.

Output
Calculate and print the distance value using the provided formula, with 4 decimal places.
*/

using System;
using System.Globalization;

namespace urionlinejudge {
    class Example1015 {
        static void Main(string[] args) {
            double x1, y1, x2, y2, distance;
            string[] x = Console.ReadLine().Split(' ');
            x1 = double.Parse(x[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(x[1], CultureInfo.InvariantCulture);
            string[] y = Console.ReadLine().Split(' ');
            x2 = double.Parse(y[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(y[1], CultureInfo.InvariantCulture);
            distance = Math.Sqrt((Math.Pow((x2-x1), 2))+Math.Pow((y2-y1),2));
            Console.WriteLine($"{distance.ToString("F4", CultureInfo.InvariantCulture)}");
            

        }
    }
}
