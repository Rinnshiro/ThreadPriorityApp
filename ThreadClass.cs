using System;
using System.Threading;

namespace ThreadPriorityApp
{
    public class ThreadClass
    {
        public static void Thread1()
        {
            for (int loopCount = 0; loopCount < 3; loopCount++)
            {
                Thread.Sleep(500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
				Thread.Sleep(500);
			}
        }

        public static void Thread2()
        {
            for (int loopCount = 0; loopCount < 6; loopCount++)
            {
                Thread.Sleep(1500);
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
            }
        }
    }
}
