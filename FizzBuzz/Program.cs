namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 100; x++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                // divisible by 4 numbers
                if (x % 3 == 0 && x % 5 == 0 && x % 7 == 0 && x % 11 == 0)
                {
                    Console.WriteLine("FizzBuzzBizzFuzz");
                }
                // divisible by 3 numbers
                else if (x % 3 == 0 && x % 5 == 0 && x % 7 == 0)
                {
                    Console.WriteLine("FizzBuzzBizz");
                }
                else if (x % 3 == 0 && x % 5 == 0 && x % 11 == 0)
                {
                    Console.WriteLine("FizzBuzzFuzz");
                }
                else if (x % 3 == 0 && x % 7 == 0 && x % 11 == 0)
                {
                    Console.WriteLine("FizzBizzFuzz");
                }
                else if (x % 5 == 0 && x % 7 == 0 && x % 11 == 0)
                {
                    Console.WriteLine("BuzzBizzFuzz");
                }
                // divisible by 2 numbers 
                else if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (x % 3 == 0 && x % 7 == 0)
                {
                    Console.WriteLine("FizzBizz");
                }
                else if (x % 3 == 0 && x % 11 == 0)
                {
                    Console.WriteLine("FizzFuzz");
                }
                else if (x % 5 == 0 && x % 7 == 0)
                {
                    Console.WriteLine("BuzzBizz");
                }
                else if (x % 5 == 0 && x % 11 == 0)
                {
                    Console.WriteLine("BuzzFuzz");
                }
                else if (x % 7 == 0 && x % 11 == 0)
                {
                    Console.WriteLine("BizzFuzz");
                }
                // divisible by 1 number
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (x % 7 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else if (x % 11 == 0)
                {
                    Console.WriteLine("Fuzz");
                }
                // divisible by no numbers
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(x);
                }
            }
        }
    }
}