/*
In this problem you have to read an integer value and calculate the smallest possible number of banknotes in which the value may be decomposed. The possible banknotes are 100, 50, 20, 10, 5, 2 and 1. Print the read value and the list of banknotes.

Input
The input file contains an integer value N (0 < N < 1000000).

Output
Print the read number and the minimum quantity of each necessary banknotes in Portuguese language, as the given example. Do not forget to print the end of line after each line, otherwise you will receive “Presentation Error”.
*/

using System;

namespace urionlinejudge {
    class Example1018 {
        static void Main(string[] args) {
            int value, qtd100notes, qtd50notes, qtd20notes, qtd10notes, qtd5notes, qtd2notes, qtd1notes;
            value = int.Parse(Console.ReadLine());
            qtd100notes = value / 100;
            qtd50notes = (value % 100) / 50;
            qtd20notes = ((value % 100) % 50) / 20;
            qtd10notes = (((value % 100) % 50) % 20) / 10;
            qtd5notes = ((((value % 100) % 50) % 20) % 10) / 5;
            qtd2notes = (((((value % 100) % 50) % 20) % 10) % 5) / 2;
            qtd1notes = ((((((value % 100) % 50) % 20) % 10) % 5) % 2) / 1;
            Console.WriteLine($"{value}");
            Console.WriteLine($"{qtd100notes} nota(s) de R$ 100,00");
            Console.WriteLine($"{qtd50notes} nota(s) de R$ 50,00");
            Console.WriteLine($"{qtd20notes} nota(s) de R$ 20,00");
            Console.WriteLine($"{qtd10notes} nota(s) de R$ 10,00");
            Console.WriteLine($"{qtd5notes} nota(s) de R$ 5,00");
            Console.WriteLine($"{qtd2notes} nota(s) de R$ 2,00");
            Console.WriteLine($"{qtd1notes} nota(s) de R$ 1,00");
        }
    }
}
