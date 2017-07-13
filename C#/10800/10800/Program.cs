using System;

namespace _10800
{
    class Program
    {
        class Ball : IComparable<Ball> {
            public int size;
            public int eatablesum;
            public int CompareTo (Ball other) {
                return size - other.size;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Ball[] balls = new Ball[n];
            Ball[] balls2 = new Ball[n];
            Ball[][] balls3 = new Ball[n][];
            for (int i=0; i<n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' });
                balls[i] = new Ball();
                balls[i].size = int.Parse(input[1]);
                balls[i].eatablesum = 0;
                balls2[i] = balls[i];
                balls3[int.Parse(input[0])][balls3[int.Parse(input[0])].Length - 1] = balls[i];
            }
            Array.Sort(balls2);
            balls2[0].eatablesum = 0;
            for (int i=1; i<n; i++) {
                balls2[i].eatablesum = balls2[i-1].eatablesum;
                Console.WriteLine(balls[i].eatablesum);
            }
        }
    }
}
