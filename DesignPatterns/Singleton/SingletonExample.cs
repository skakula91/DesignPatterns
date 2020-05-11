using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonExample
    {
        //Lazy loading
        private static readonly Lazy<SingletonExample> instance = new Lazy<SingletonExample>(() => new SingletonExample());
        //private static readonly object lockInstance = new object();
        public static SingletonExample GetInstance
        {
            get
            {
            //    if (instance == null)
            //    {
            //        lock (lockInstance)
            //        {
            //            if (instance == null)
            //                instance = new SingletonExample();
            //        }
            //    }
                return instance.Value;
            }
        }
        private static int counter = 0;
        private SingletonExample()
        {
            counter++;
            Console.WriteLine($"Instance Count:{counter}");
        }

        public void PrintDetails(string str)
        {
            Console.WriteLine(str);
        }
    }
}
