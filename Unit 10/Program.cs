using System;
using System.IO;
using System.Collections.Generic;


namespace Unit_10
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }
    public interface ILogger
    {
        void Event(string messege);
        void Error(string messege);
    }
    public class Logger : ILogger
    {
        public void Error(string messege)
        {
            Console.WriteLine(messege);
        }
        public void Event(string messege)
        {
            Console.WriteLine(messege);
        }
    }
    public interface IWorker
    {
        void Work();
    }
}

