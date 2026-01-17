/*
Read an integer value, which is the duration in seconds of a certain event in a factory, and inform it expressed in hours:minutes:seconds.

Input
The input file contains an integer N.

Output
Print the read time in the input file (seconds) converted in hours:minutes:seconds like the following example.
*/

using System;

namespace exercises {
    class Exercise4 {
        static void Main(string[] args) {
            int n, hours, minutes, seconds;
            n = int.Parse(Console.ReadLine());
            hours = n / 3600;
            minutes = (n % 3600) / 60;
            seconds = n % 60;
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
