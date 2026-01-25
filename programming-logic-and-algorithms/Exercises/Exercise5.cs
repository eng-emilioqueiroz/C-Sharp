/*

Write a program to read two grades a student obtained in the first and second semesters of a year-long course.
Then, display the student's final grade for the year along with an explanatory text. 
If the student's final grade is less than 60.00, display the message "FAILED", as shown in the examples. All values ​​must have one decimal place.
*/

using System;
using System.Globalization;

namespace exercises {
    class Exercise5 {
        static void Main(string[] args) {
            double grade1, grade2, finalGrade;
            grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            finalGrade = grade1 + grade2;
            // Use invariant culture when formatting the numeric value
            Console.WriteLine($"FINAL GRADE = {finalGrade.ToString("F1", CultureInfo.InvariantCulture)}");
            if (finalGrade < 60.0) {
                Console.WriteLine("FAILED");
            }
        }
    }
}
