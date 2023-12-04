namespace Task5_3
{
    internal class Program
    {
        static long Fib(int n)
        {
            
            
                if ((n == 1) || (n == 2))
                    return 1;
                return Fib(n - 1) + Fib(n - 2);
            
        }
        static void Main(string[] args)

        {
            Console.WriteLine("Enter count of numbers");
            int n = int.Parse(Console.ReadLine());
            
                       
            for (int i = 1;i <= n; i++)
            {
                Console.WriteLine(Fib(i));
                
            }
            
        }
    }
}
