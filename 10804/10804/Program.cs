using System;

namespace _10804
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for(int i=0; i<20; i++)
            {
                array[i] = i + 1;
            }
            for(int i=0; i<10; i++)
            {
                string[] range = Console.ReadLine().Split(new char[] { ' ' });
                int str = int.Parse(range[0])-1;
                int end = int.Parse(range[1])-1;
                int times = (int)((end-str) * 0.5f) +1;
                for(int j=0; j<times; j++)
                {
                    int temp = array[str + j];
                    array[str + j] = array[end - j];
                    array[end - j] = temp;
                }
            }
            for (int i=0; i<20; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
