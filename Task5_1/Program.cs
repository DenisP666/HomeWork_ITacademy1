

namespace Task5_1
{
    public class Program
    {
        static int Multiplier(int a, int b)

        {
            int c = b;
            int Result = 0;
            for (b = 1; b <= c; b++)
            {
                Result = a * b;
                Console.WriteLine($"{a} * {b} = {Result}");
            }
            return Result;

        }

        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            int Result = Multiplier(a, b);
        }


    }
}
