
namespace ThirdProgram {
    class ProcessingData {
        static void Main(string[] args) {
            int a, b;
            double result;

            a = 5;
            b = 2;

            result = (double)a / b; //casting to avoid integer division
            Console.WriteLine($"Result of division: {result}");
        }

    }
}
