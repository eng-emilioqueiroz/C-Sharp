using System;
using System.Globalization;

namespace FirstProgram {
    class PrintingMessages {
        static void Main(string[] args) {
            //declaring variables
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'M';
            //printing messages
            Console.Write("Hello World!"); //print without newline
            Console.WriteLine("Good Morning!"); //print with newline
            Console.WriteLine("See you later!");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); //formatting to 2 decimal places
            Console.WriteLine(x.ToString("F4")); // formatting to 4 decimal places
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // formatting to 2 decimal places with invariant culture
            Console.WriteLine("The x value is " + x); // concatenation
            Console.WriteLine($"The x value is {x}"); // concatenation
            Console.WriteLine("The x value is " + x.ToString("F2") + " reais"); // concatenation with formatting
            Console.WriteLine($"The lady called {z} have {y} years and her nickname is {w}"); // interpolation
            Console.ReadLine();
        }
    }
}


