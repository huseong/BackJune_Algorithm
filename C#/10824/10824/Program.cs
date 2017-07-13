using System;

namespace _10824
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' });
            ulong a = ulong.Parse(input[0] + input[1]);
            ulong b = ulong.Parse(input[2] + input[3]);
            Console.Write(a + b);
        }
    }
}
