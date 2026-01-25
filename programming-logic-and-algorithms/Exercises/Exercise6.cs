/*

Write a program to read three integers.
Then, display the smallest of the three numbers read.
In case of a tie, display it only once.
*/

using System;

namespace exercises {
    class Exercise6 {
        static void Main(string[] args) {
            int number1, number2, number3, maior;
            string[] numbers = Console.ReadLine().Split(' ');
            number1 = int.Parse(numbers[0]);
            number2 = int.Parse(numbers[1]);
            number3 = int.Parse(numbers[2]);
            if (number1 < number2 && number1 < number3) {
                Console.WriteLine($"MENOR: {number1}");
            }
            else if (number2 < number1 && number2 < number3) {
                Console.WriteLine($"MENOR: {number2}");
            }
            else {
                Console.WriteLine($"MENOR: {number3}");
            }


        }
    }
}
