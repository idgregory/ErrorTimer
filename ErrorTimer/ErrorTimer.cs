using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class ErrorTimer
    {
        private bool isError, hasChange;
        private Thread t;

        public ErrorTimer(int seconds)
        {
            isError = false;
            hasChange = false;
            t = new Thread(() => { hasError = waitForError(seconds); });
        }

        //Starts the thread that waits a certain amount of time
        public void start()
        {
            t.Start();
        }

        //Checks if thread is still running
        public bool isAlive()
        {
            return t.IsAlive;
        }

        //get set method that invokes a function when the variable is changed
        public bool hasError
        {
            get { return isError; }

            set
            {
                isError = value;
                OnErrorChange();
            }
        }

        //Method invoded by hasError
        private void OnErrorChange()
        {

            if(!this.hasChange)
            {
                Console.WriteLine("Continue");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        //Waits three seconds then executes code
        public bool waitForError(int seconds)
        {
            Random r = new Random();
            int rand = r.Next(0, 1);
            Thread.Sleep(seconds * 1000);
            return (rand == 1);
        }

    }
}
