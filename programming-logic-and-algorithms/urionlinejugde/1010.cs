/*
In this problem, the task is to read a code of a product 1, the number of units of product 1, the price for one unit of product 1, the code of a product 2, the number of units of product 2 and the price for one unit of product 2. After this, calculate and show the amount to be paid.

Input
The input file contains two lines of data. In each line there will be 3 values: two integers and a floating value with 2 digits after the decimal point.

Output
The output file must be a message like the following example where "Valor a pagar" means Value to Pay. Remember the space after ":" and after "R$" symbol. The value must be presented with 2 digits after the point.
*/

using System;
using System.Globalization;

namespace urionlinejudge {
    class Example1010 {
        static void Main(string[] args) {
            int code1, number1, code2, number2;
            double price1, price2, valueToPay;
            string[] product1 = Console.ReadLine().Split(' ');
            code1 = int.Parse(product1[0]);
            number1 = int.Parse(product1[1]);
            price1 = double.Parse(product1[2], CultureInfo.InvariantCulture);
            string[] product2 = Console.ReadLine().Split(' ');
            code2 = int.Parse(product2[0]);
            number2 = int.Parse(product2[1]);
            price2 = double.Parse(product2[2], CultureInfo.InvariantCulture);
            valueToPay = (number1 * price1) + (number2 * price2);
            Console.WriteLine($"VALOR A PAGAR: R$ {valueToPay.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
