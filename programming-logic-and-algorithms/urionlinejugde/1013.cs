/*
Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior". Use the following formula:

Input
The input file contains 3 integer values.

Output
Print the greatest of these three values followed by a space and the message “eh o maior”.
*/

using System;
using System.Globalization;

namespace urionlinejudge {
    class Example1013 {
        static void Main(string[] args) {
            int A, B, C, greatestAB, greatestBC;
            string[] numbers = Console.ReadLine().Split();
            A = int.Parse(numbers[0], CultureInfo.InvariantCulture);
            B = int.Parse(numbers[1], CultureInfo.InvariantCulture);
            C = int.Parse(numbers[2], CultureInfo.InvariantCulture);
            greatestAB = ((A + B + Math.Abs(A - B)) / 2);
            greatestBC = ((greatestAB + C + Math.Abs(greatestAB - C)) / 2);
            Console.WriteLine($"{greatestBC} eh o maior");            
        }
    }
}
