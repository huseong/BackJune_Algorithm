using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11648
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; ; i++)
            {
                if (n.ToString().Length == 1)
                {

                    Console.Write(i);
                    break;
                }
                int temp=1;
                for(int j=0; j<n.ToString().Length; j++)
                {
                    temp *= n.ToString()[j]-48;
                   
                }
                n = temp;
                
            }
        }
    }
}
