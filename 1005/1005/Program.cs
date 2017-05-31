using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005
{
    class Program
    {
        public static int max=0;
        class huseong
        {
            public int name;
            public int time;
            public List<int> child=new List<int>();
            public int children;
            public static void kal(List<huseong> go, int bunja, int time, int[] dp)
            {
                time += go[bunja].time;
                if(dp[bunja]==0)
                {
                    dp[bunja] = time;
                }
                for (int j = 0; j < go[bunja].children; j++)
                {
                    if (dp[go[bunja].child[j] - 1] != 0)
                    {
                        time += dp[go[bunja].child[j] - 1];
                    }
                    else
                    {
                        kal(go, go[bunja].child[j] - 1, time, dp);
                    }
                }
                if (time > max)
                {
                    max = time;
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] time = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                string[] scan = Console.ReadLine().Split(new char[] { ' ' });
                List<huseong> go = new List<huseong> ();
                int[] children = new int[int.Parse(scan[0])];
                string[] scon = Console.ReadLine().Split(new char[] { ' ' });
                int skan = int.Parse(scan[0]);
                int skon = int.Parse(scan[1]);
                int[] dp = new int[skan];
                for(int j=0; j<skan; j++)
                {
                    dp[j] = 0;
                }
                for (int j = 0; j < skan; j++)
                {
                    huseong kong = new huseong { name = j, time = int.Parse(scon[j]) };
                    go.Add(kong);
                }
                for (int j = 0; j < skon; j++)
                {
                    string[] skun = Console.ReadLine().Split(new char[] { ' ' });
                    go[int.Parse(skun[1]) - 1].child.Add(int.Parse(skun[0]));
                }
                for(int p=0; p<skan; p++)
                {
                    go[p].children=go[p].child.Count;
                }
                int k = int.Parse(Console.ReadLine());
                huseong.kal(go, k-1, 0, dp);
                time[i] = max;
                max = 0;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(time[i]);
            }
        }
    }
}
