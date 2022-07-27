using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Unit_10
{
    public class Worker1: IWorker
    {
        ILogger Logger {get;}
        public Worker1(ILogger logger)
        {

        }

        public void Work()
        {
            Logger.Event("Worker1 начал работу ");
            Thread.Sleep(3000);
            Logger.Event("Worker1 закончил работу ");
        }
    }
    public class Worker2 : IWorker
    {
        ILogger Logger { get; }
        public Worker2(ILogger logger)
        {

        }

        public void Work()
        {
            Logger.Event("Worker2 начал работу ");
            Thread.Sleep(3000);
            Logger.Event("Worker2 закончил работу ");
        }
    }
    public class Worker3 : IWorker
    {
        ILogger Logger { get; }
        public Worker3(ILogger logger)
        {

        }

        public void Work()
        {
            Logger.Event("Worker3 начал работу ");
            Thread.Sleep(3000);
            Logger.Event("Worker3 закончил работу ");
        }
    }

}
