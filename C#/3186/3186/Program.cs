using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3186 {
    class Program {
        public enum Status {
            Using, idle, Non
        }
        static void Main (string[] args) {
            string[] input = Console.ReadLine().Split(' ');
            int userCheckTime = int.Parse(input[0]);
            int completeTime = int.Parse(input[1]);
            int timeLength = int.Parse(input[2]);
            string timeInput = Console.ReadLine();
            int personStandingTime = 0;
            int usingAfterTime = 0;
            Status stat = Status.Non;
            bool isFlush = false;
            for(int i=0; i<timeLength; i++) {
                if(timeInput[i] == '1') {
                    personStandingTime++;
                    usingAfterTime = 0;
                    if(personStandingTime >= userCheckTime) {
                        stat = Status.Using; // 사용중이라 기록함.
                    }
                } else {
                    personStandingTime = 0;
                    if(stat != Status.Non) {
                        stat = Status.idle;
                        usingAfterTime ++;
                    }
                    if(usingAfterTime >= completeTime) {
                        Console.WriteLine(i + 1);
                        stat = Status.Non;
                        isFlush = true;
                        usingAfterTime = 0;
                    }
                }
            }
            if(stat == Status.idle) {
                isFlush = true;
                Console.WriteLine(timeLength + completeTime - usingAfterTime);
            }
            else if(stat == Status.Using) {
                isFlush = true;
                Console.WriteLine(timeLength + completeTime);
            }
            if(!isFlush) {
                Console.WriteLine("NIKAD");
            }
        }
    }
}
