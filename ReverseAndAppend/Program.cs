using System;

namespace ReverseAndAppend
{
    class Program
    {
        // https://edabit.com/challenge/YGhgctqPsKQxQQCFS
        // SOLVED

        static void Main(string[] args)
        {
            Reverser reverse = new("123456789"); // -> "987654321123456789"
            Console.WriteLine(reverse.ReverseString());
        }
    }
}
