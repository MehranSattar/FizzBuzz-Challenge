using System;

namespace Fizzbuzz
{
    public class Fizzbuzz
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                i++;
                Console.WriteLine(FizzorBuzz.modulus(i));
            }
        }
        static class FizzorBuzz
        {
            public static dynamic modulus(int i)
            {
                if ((i % 5 == 0) && (i % 3 == 0))
                {
                    return "FizzBuzz";
                }
                else if (i % 5 == 0)
                {
                    return "Buzz";
                }
                else if (i % 3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    return i;
                }
            }
        }
    }
}
