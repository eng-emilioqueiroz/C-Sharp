using System;
using System.Globalization;

namespace SecondProgram {
    class InputData {
        static void Main(string[] args) {
            string sentence,x,y,z,s  = "";
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();
            Console.WriteLine($"\nYou entered: {sentence} \n");
            Console.Write("Enter a first color: ");
            x = Console.ReadLine();
            Console.Write("Enter a second color: ");
            y = Console.ReadLine();
            Console.Write("Enter a third color: ");
            z = Console.ReadLine();
            Console.WriteLine($"\nYou entered the colors: {x}, {y} e {z}");
            Console.Write("\nEnter a list of fruits: ");
            s = Console.ReadLine();
            string[] vet = s.Split(' '); // Splitting the input string into an array
            Console.Write("\nYou entered the fruits: ");
            foreach (string fruit in vet) {
                Console.Write($"{fruit} ");
            }

        }
    }

}


