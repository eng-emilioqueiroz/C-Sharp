using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram {
    class InputData2 {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine($"You wrote {n1} and {ch} and {n2.ToString("F2", CultureInfo.InvariantCulture)}");
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            char sexo = char.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine($"You wrote {nome} and {idade} and {sexo} and {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
