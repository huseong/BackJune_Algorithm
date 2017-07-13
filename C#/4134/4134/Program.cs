using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4134
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ka;
            List<uint> scan = new List<uint>();
            for(ka=0; ka<n; ka++)
            {
                scan.Add(uint.Parse(Console.ReadLine()));
            }
            ka--;
            scan.Sort();
            List<uint> list = new List<uint>();
            list.Add(2);
            for(uint i=3; i<scan[ka]+20; i+=2)
            {
                bool primNum = true;
                uint iSqrt = (uint)Math.Sqrt(i);
                int listLeg = list.Count;
                for(int j=0; list[j]<=iSqrt; j++)
                {
                    if(i%list[j]==0)
                    {
                        primNum = false;
                        break;
                    }
                }
                if(primNum)
                {
                    list.Add(i);
                }
            }
            int scanCount = scan.Count;
            int listleg = list.Count;
            int lo = 0;
            for (int j = 0; j < listleg; j++)
            {
                if (list[j] > scan[lo])
                {
                    Console.Write(list[j] + "\n");
                    if (lo < scanCount-1)
                        lo++;
                    else
                        break;
                }
            }
        }
    }
}
