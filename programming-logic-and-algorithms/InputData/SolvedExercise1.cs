using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SecondProgram {
    class SolvedExercise1 {
        static void Main(string[] args) {

            double width, lenght, pricePerSquareMeter, area, price;

            Console.Write("Enter the width of the land: ");
            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the lenght of the land: ");
            lenght = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the price per square meter $");
            pricePerSquareMeter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = width * lenght;
            price = area * pricePerSquareMeter;
            Console.WriteLine($"The area of the land is: {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"The price of the land is ${price.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
