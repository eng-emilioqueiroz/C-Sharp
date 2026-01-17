/*
Read an integer value corresponding to a person's age (in days) and print it in years, months and days, followed by its respective message “ano(s)”, “mes(es)”, “dia(s)”.

Note: only to facilitate the calculation, consider the whole year with 365 days and 30 days every month. In the cases of test there will never be a situation that allows 12 months and some days, like 360, 363 or 364. This is just an exercise for the purpose of testing simple mathematical reasoning.

Input
The input file contains 1 integer value.

Output
Print the output, like the following example.
*/

using System;

namespace urionlinejudge {
    class Example1020 {
        static void Main(string[] args) {
            int age, years, months, days;
            age= int.Parse(Console.ReadLine());
            years = age / 365;
            months = (age % 365) / 30;
            days = (age % 365) % 30;
            Console.WriteLine($"{years} ano(s)");
            Console.WriteLine($"{months} mes(es)");
            Console.WriteLine($"{days} dia(s)");

        }
    }
}
