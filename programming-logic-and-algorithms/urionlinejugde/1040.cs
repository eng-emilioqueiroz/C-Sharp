/*
Read four numbers (N1, N2, N3, N4), which one with 1 digit after the decimal point, corresponding to 4 scores obtained by a student.
Calculate the average with weights 2, 3, 4 e 1 respectively, for these 4 scores and print the message "Media: " (Average), followed by the calculated result.
If the average was 7.0 or more, print the message "Aluno aprovado." (Approved Student).
If the average was less than 5.0, print the message: "Aluno reprovado." (Reproved Student).
If the average was between 5.0 and 6.9, including these, the program must print the message "Aluno em exame." (In exam student).

In case of exam, read one more score. Print the message "Nota do exame: " (Exam score) followed by the typed score. Recalculate the average (sum the exam score with the previous calculated average and divide by 2) and print the message “Aluno aprovado.” (Approved student) in case of average 5.0 or more) or "Aluno reprovado." (Reproved student) in case of average 4.9 or less. For these 2 cases (approved or reproved after the exam) print the message "Media final: " (Final average) followed by the final average for this student in the last line.

Input
The input contains four floating point numbers that represent the students' grades.

Output
Print all the answers with one digit after the decimal point.
 */
using System;
using System.Globalization;

namespace urionlinejugde {
    class Example1040 {
        static void Main() {
            double N1, N2, N3, N4, media, notaExame;
            string[] notes = Console.ReadLine().Split(' ');
            N1 = double.Parse(notes[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(notes[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(notes[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(notes[3], CultureInfo.InvariantCulture);
            media = (N1 * 2.0 + N2 * 3.0 + N3 * 4.0 + N4 * 1.0) / 10.0;
            media = Math.Truncate(media * 10) / 10.0;
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            if (media >= 7) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5) {
                Console.WriteLine("Aluno reprovado.");
            }
            else {
                Console.WriteLine("Aluno em exame.");
                notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", CultureInfo.InvariantCulture)}");
                media = (media + notaExame) / 2.0;
                if(media >= 5) {
                    Console.WriteLine("Aluno aprovado.");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }

        }

    }
}
