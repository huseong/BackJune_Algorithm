using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2606
{
    class Program
    {
        class Computer
        {
            public int id;
            public bool isWarm = false;
            public List<Computer> linkedComputer;
            public void Warm()
            {
                for(int i=0; i<linkedComputer.Count; i++)
                {
                    if (linkedComputer[i].isWarm)
                        continue;
                    linkedComputer[i].isWarm = true;
                    linkedComputer[i].linkedComputer.Remove(this);
                    linkedComputer[i].Warm();
                }
            }
            public Computer(int id)
            {
                this.id = id;
                linkedComputer = new List<Computer>();
            }
        }

        static void Main(string[] args)
        {
            int computerCount = int.Parse(Console.ReadLine());
            Computer[] coms = new Computer[computerCount];
            for(int i=0; i<computerCount; i++)
            {
                coms[i] = new Computer(i);
            }
            int linkNum = int.Parse(Console.ReadLine());
            for(int i=0; i<linkNum; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                coms[int.Parse(input[0])-1].linkedComputer.Add(coms[int.Parse(input[1])-1]);
                coms[int.Parse(input[1])-1].linkedComputer.Add(coms[int.Parse(input[0])-1]);
            }
            coms[0].isWarm = true;
            coms[0].Warm();
            int count = 0;
            for(int i=0; i<computerCount; i++)
            {
                if (coms[i].isWarm)
                    count++;
            }
            Console.WriteLine(count-1);
        }
    }
}
