/*
Write a program to read the width and height measurements of a rectangle. Then, display the area, perimeter, and diagonal of this rectangle, with four decimal places, as in the example.
*/

using System;
using System.Globalization;

namespace exercises {
    class Exercise2 {
        static void Main(string[] args) {
            double width, height, area, perimeter, diagonal;
            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = width * height;
            perimeter = height * area;
            diagonal = Math.Sqrt(width * width + height * height);
            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETER = " + perimeter.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));           

        }
    }
}
