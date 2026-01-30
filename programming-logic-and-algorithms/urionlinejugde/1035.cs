/*
Read 4 integer values A, B, C and D. Then if B is greater than C and D is greater than A and if the sum of C and D is greater than the sum of A and B and if C and D were positives values and if A is even, write the message “Valores aceitos” (Accepted values). Otherwise, write the message “Valores nao aceitos” (Values not accepted).

Input
Four integer numbers A, B, C and D.

Output
Show the corresponding message after the validation of the values​​.
*/

using System;

namespace urionlinejudge {
    class Example1035 {
        static void Main(string[] args) {
            int A, B, C, D;
            string[] numbers = Console.ReadLine().Split(' ');
            A = int.Parse(numbers[0]);
            B = int.Parse(numbers[1]);
            C = int.Parse(numbers[2]);
            D = int.Parse(numbers[3]);
            if ((B > C) &&  (D > A) && ((C+D) > (A+B)) && (B > 0) && (C > 0) && (A%2 == 0)) {
                Console.WriteLine("Valores aceitos");
            }
            else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
