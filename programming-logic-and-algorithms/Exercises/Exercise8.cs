/*
Write a program to read an integer value from 1 to 7 representing a day of the week 
(Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, and Saturday = 7). 
Display the corresponding day of the week on the screen.
*/

using System;
using System.Globalization;

namespace exercises {
    class Exercise8 {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number followed by 1 through 7 to find out the day of the week.");
            int value = int.Parse(Console.ReadLine());
            switch (value) {
                case 1:
                    Console.WriteLine("Day of the week: Domingo");
                    break;
                case 2:
                    Console.WriteLine("Day of the weeka: Segunda");
                    break;
                case 3:
                    Console.WriteLine("Day of the week: Terça");
                    break;
                case 4:
                    Console.WriteLine("Day of the week: Quarta");
                    break;
                case 5:
                    Console.WriteLine("Day of the weeka: Quinta");
                    break;
                case 6:
                    Console.WriteLine("Day of the weeka: Sexta");
                    break;
                case 7:
                    Console.WriteLine("Day of the week: Sábado");
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }
    }
}
