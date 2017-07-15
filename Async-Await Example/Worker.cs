using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await_Example
{
    class Worker
    {
        public bool IsComplete { get; private set; }

        public async void DoWork()
        {
            this.IsComplete = false;
            Console.WriteLine("Doing work");

            await LongOperation();

            Console.WriteLine("Work completed");

            IsComplete = true;
        }

        private Task LongOperation()
        {
            return Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Working!");
                    Thread.Sleep(2000);
                });
        }
    }
}
