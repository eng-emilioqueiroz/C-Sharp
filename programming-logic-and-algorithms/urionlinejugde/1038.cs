/*
Using the following table, write a program that reads a code and the amount of an item. After, print the value to pay. This is a very simple program with the only intention of practice of selection commands.
Input
The input file contains two integer numbers X and Y. X is the product code and Y is the quantity of this item according to the above table.
Output
The output must be a message "Total: R$ " followed by the total value to be paid, with 2 digits after the decimal point.
*/

using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace urionlinejudge {
    class Example1038 {
        static void Main() {
            int x, y;
            double price = 0.0, totalPrice;
            string[] numbers = Console.ReadLine().Split(' ');
            x = int.Parse(numbers[0]);
            y = int.Parse(numbers[1]);
            switch (x) {
                case 1:
                    price = 4.0;
                    break;
                case 2:
                    price = 4.50;
                    break;
                case 3:
                    price = 5.0;
                    break;
                case 4:
                    price = 2.0;
                    break;
                case 5:
                    price = 1.5;
                    break;
                default:
                    price = 0.0;
                    break;
            }
            totalPrice = y * price;
            Console.WriteLine($"Total: R$ {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}" );
        }
    }
}
