using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
   
        static void Main(string[] args)
        {
            ErrorTimer et = new ErrorTimer();
            et.start(); //start thread
            while(et.isAlive())
            {
                Thread.Sleep(1000);
                Console.WriteLine("Still threading");
            }
            Console.ReadLine();
        }
    }
}
