using System;
using System.Globalization;
namespace FirstProgram {
    class FirstProgram {
        static void Main(string[] args) {
            //declaring variables
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';
            //printing messages
            Console.Write("Olá mundo!"); //print without newline
            Console.WriteLine("Bom dia!"); //print with newline
            Console.WriteLine("Até mais!");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2")); //formatting to 2 decimal places
            Console.WriteLine(x.ToString("F4")); // formatting to 4 decimal places
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // formatting to 2 decimal places with invariant culture
            Console.WriteLine("RESULTADO = " + x); // concatenation
            Console.WriteLine("O valor do troco é " + x + " reais"); // concatenation
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais"); // concatenation with formatting
            Console.WriteLine($"A paciente {z} tem {y} anos e seu sexo é {w}"); // interpolation
            Console.ReadLine();
        }
    }
}
