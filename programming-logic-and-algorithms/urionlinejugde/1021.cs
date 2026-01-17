/*
Read a value of floating point with two decimal places. This represents a monetary value. After this, calculate the smallest possible number of notes and coins on which the value can be decomposed. The considered notes are of 100, 50, 20, 10, 5, 2. The possible coins are of 1, 0.50, 0.25, 0.10, 0.05 and 0.01. Print the message “NOTAS:” followed by the list of notes and the message “MOEDAS:” followed by the list of coins.

Input
The input file contains a value of floating point N (0 ≤ N ≤ 1000000.00).

Output
Print the minimum quantity of banknotes and coins necessary to change the initial value, as the given example.
*/

using System;
using System.Globalization;

namespace urionlinejudge {
    class Example1021 {
        static void Main(string[] args) {
            double value;
            int correctValue, qtd100Notes, qtd50Notes, qtd20Notes, qtd10Notes, qtd5Notes, qtd2Notes, qtd1Coin, qtd050Coins, qtd025Coins, qtd010Coins, qtd005Coins, qtd001Coins;
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            correctValue = (int) (value * 100 + 0.5);
            qtd100Notes = (int) (correctValue / 10000);
            qtd50Notes = (int) ((correctValue % 10000) / 5000);
            qtd20Notes = (int) (((correctValue % 10000) % 5000) / 2000);
            qtd10Notes = (int) ((((correctValue % 10000) % 5000) % 2000) / 1000);
            qtd5Notes = (int) (((((correctValue % 10000) % 5000) % 2000) % 1000) / 500);
            qtd2Notes = (int) ((((((correctValue % 10000) % 5000) % 2000) % 1000) % 500) / 200);
            qtd1Coin = (int) (((((((correctValue % 10000) % 5000) % 2000) % 1000) % 500) % 200) / 100);
            qtd050Coins = (int) ((((((((correctValue % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) / 50);
            qtd025Coins = (int) (((((((((correctValue % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) / 25);
            qtd010Coins = (int) ((((((((((correctValue % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) / 10);
            qtd005Coins = (int) (((((((((((correctValue % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) % 10) / 5);
            qtd001Coins = (int) ((((((((((((correctValue % 10000) % 5000) % 2000) % 1000) % 500) % 200) % 100) % 50) % 25) % 10) % 5) / 1);

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{qtd100Notes} nota(s) de R$ 100.00");
            Console.WriteLine($"{qtd50Notes} nota(s) de R$ 50.00");
            Console.WriteLine($"{qtd20Notes} nota(s) de R$ 20.00");
            Console.WriteLine($"{qtd10Notes} nota(s) de R$ 10.00");
            Console.WriteLine($"{qtd5Notes} nota(s) de R$ 5.00");
            Console.WriteLine($"{qtd2Notes} nota(s) de R$ 2.00");
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{qtd1Coin} moeda(s) de R$ 1.00");
            Console.WriteLine($"{qtd050Coins} moeda(s) de R$ 0.50");
            Console.WriteLine($"{qtd025Coins} moeda(s) de R$ 0.25");
            Console.WriteLine($"{qtd010Coins} moeda(s) de R$ 0.10");
            Console.WriteLine($"{qtd005Coins} moeda(s) de R$ 0.05");
            Console.WriteLine($"{qtd001Coins} moeda(s) de R$ 0.01");

        }
    }
}
