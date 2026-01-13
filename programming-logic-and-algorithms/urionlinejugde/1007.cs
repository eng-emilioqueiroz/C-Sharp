/*
Read four integer values named A, B, C and D. Calculate and print the difference of product A and B by the product of C and D (A * B - C * D).

Input
The input file contains 4 integer values.

Output
Print DIFERENCA (DIFFERENCE in Portuguese) with all the capital letters, according to the following example, with a blank space before and after the equal signal.
*/

using System;

namespace urionlinejudge {
    class Example1007 {
        static void Main(string[] args) {
            int A, B, C, D, DIFFERENCE;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            DIFFERENCE = (A * B) - (C * D);
            Console.WriteLine($"DIFFERENCE = {DIFFERENCE}");
        }
    }

}
