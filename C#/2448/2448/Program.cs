using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2448
{
    class Program
    {
        static void oneline()
        {
            Console.Write("  *  ");
            Console.Write(" ");
        }
        static void twoline()
        {
            Console.Write(" * * ");
            Console.Write(" ");
        }
        static void threeline()
        {
            Console.Write("*****");
            Console.Write(" ");
        }
        static bool jegob(int a)
        {
            int j=2;
            for(int i=1; i<=10; i++)
            {
                if(a==j+1)
                {
                    return true;
                }
                j *= 2;
            }
            return false;
        }



        static void onekey(int a, int count)
        {


            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a - i; j++)
                {
                    Console.Write("   ");
                }
                for (int j = 1; j <= i; j++)
                {
                    oneline();
                    if (i % count == 3)
                    {
                        Console.Write("      ");
                        j++;
                    }
                    else if (i % count == 2 && j == 2)
                    {
                        for (int k = 1; k <= i - count; k++)
                        {
                            Console.Write("      ");
                            j++;
                        }
                    }
                    else if (i % 4 == 1)
                    {
                        for (int k = 1; k <= i - 2; k++)
                        {
                            Console.Write("      ");
                            j++;
                        }
                    }
                }
                Console.WriteLine();
                for (int j = 1; j <= a - i; j++)
                {
                    Console.Write("   ");
                }
                for (int j = 1; j <= i; j++)
                {
                    twoline();
                    if (i % count == 3)
                    {
                        Console.Write("      ");
                        j++;
                    }
                    else if (i % count == 2 && j == 2)
                    {
                        for (int k = 1; k <= i - count; k++)
                        {
                            Console.Write("      ");
                            j++;
                        }
                    }
                    else if (i % count == 1)
                    {
                        for (int k = 1; k <= i - 2; k++)
                        {
                            Console.Write("      ");
                            j++;
                        }
                    }
                }
                Console.WriteLine();
                for (int j = 1; j <= a - i; j++)
                {
                    Console.Write("   ");
                }
                for (int j = 1; j <= i; j++)
                {
                    threeline();
                    if (i % count == 3)
                    {
                        Console.Write("      ");
                        j++;
                    }
                    else if(i%count==2&&j==2)
                    {
                        for(int k=1; k<=i-count; k++)
                        {
                            Console.Write("      ");
                            j++;
                        }
                    }
                    else if (i%count==1)
                    {
                        for (int k = 1; k <= i - 2; k++)
                        {
                            Console.Write("      ");
                            j++;
                        }
                    }
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n / 3;
            int count = 0;
            int temp = a;
            for(int i=1; i<=a; i*=2)
            {
                count++;
            }
            onekey(a, count);
        }
    }
}
