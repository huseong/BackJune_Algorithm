using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10808
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int[] count = new int[26];
            for(int i=0; i<word.Length; i++)
            {
                char bigo = word[i];
                for(int j=0; ; j++)
                {
                    if(bigo==j+97)
                    {
                        count[j]++;
                        break;
                    }
                }
            }
            foreach(var item in count)
            {
                Console.Write(item + " ");
            }
        }
    }
}
