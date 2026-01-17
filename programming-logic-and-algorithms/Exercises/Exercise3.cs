/*
Write a program to read the name and age of two people. At the end, display a message with the names and the average age of these two people, with one decimal place.
*/

using System;
using System.Globalization;

namespace exercises {
    class Exercise3 {
        static void Main(string[] args) {
            string name1, name2;
            int age1, age2;
            string[] data;
            double averageAge;
            data = Console.ReadLine().Split(' ');
            name1 = data[0];
            age1 = int.Parse(data[1]);
            data = Console.ReadLine().Split(' ');
            name2 = data[0];
            age2 = int.Parse(data[1]);
            averageAge = (double) (age1 + age2) / 2.0;
            Console.WriteLine("The average age of " + name1 + " and " + name2 + " is " + averageAge.ToString("F1", CultureInfo.InvariantCulture) + " years.");
        }
    }
}
