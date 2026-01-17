/*
Write a program to read the width and length measurements of a rectangular plot of land with one decimal place, as well as the price per square meter of the land with two decimal places.

Then, the program should display the area of ​​the land, as well as the price of the land, both with two decimal places.
*/

using System;
using System.Globalization;

namespace exercises {
    class Exercise1 {
        static void Main(string[] args) {
            double width, length, pricePerSquareMeter, area, totalPrice;
            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            length = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pricePerSquareMeter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = width * length;
            totalPrice = area * pricePerSquareMeter;
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRICE = " + totalPrice.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
