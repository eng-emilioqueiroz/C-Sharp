/*
A telephone company charges R$50.00 for a basic plan that includes 100 minutes of calls.
Each minute exceeding the 100-minute allowance costs R$2.00.
Write a program to read the number of minutes a person has used and display the amount to be paid.
*/

using System;
using System.Globalization;

namespace exercises {
    class Exercise7 {
        static void Main(string[] args) {
            int minutes;
            double value;
            minutes = int.Parse(Console.ReadLine());
            value = 50.0;
            if (minutes > 100) {
                value += (minutes - 100) * 2.0;
            }
            Console.WriteLine($"Valor a pagar: R$ {value.ToString("F2")}");
        }
    }
}
