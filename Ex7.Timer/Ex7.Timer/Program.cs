using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex7.Timer
{
    class Program
    {
        static void Main(string[] args)
        {


            TClock time1 = new TClock(2500, TestMethod1);
            TClock time2 = new TClock(1500, TestMethod2);
        }

        private static void TestMethod2()
        {
            Console.WriteLine("Calling TestMethod 2 at: {0}", DateTime.Now);
        }

        private static void TestMethod1()
        {
            Console.WriteLine("Calling of TestMethod 1 at: {0}", DateTime.Now);
        }
    }   

        class TClock
        {
            public delegate void SomeMethod();
            public int Time { get; set; }
            public SomeMethod PrintSmthg { get; set; }

            public TClock(int time, SomeMethod tst)
            {
                this.Time = time;
                this.PrintSmthg = tst;

                Thread newThread = new Thread(() =>
                {
                    while (true)
                    {
                        this.PrintSmthg();
                        Thread.Sleep((int)this.Time);
                    }
                });

                newThread.Start();
            }

        }
}










