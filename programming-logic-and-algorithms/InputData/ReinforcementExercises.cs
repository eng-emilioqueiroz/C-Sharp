using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram {
    class ReinforcementExercises {
        static void Main(string[] args) {

            string name;
            int numberOfBedrooms;
            double productPrice;
            string[] statement;
            Console.Write("Enter your full name: ");
            name = Console.ReadLine();
            Console.Write("How many bedrooms are in your house? ");
            numberOfBedrooms = int.Parse(Console.ReadLine());
            Console.Write("Enter product price: ");
            productPrice = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Enter your last name, age, and height (same line): ");
            statement = Console.ReadLine().Split(' ');
            Console.WriteLine($"{name}");
            Console.WriteLine($"{numberOfBedrooms}");
            Console.WriteLine($"{productPrice.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{statement[0]}");
            Console.WriteLine($"{statement[1]}");
            Console.WriteLine($"{statement[2]}");
        }

    }
}
