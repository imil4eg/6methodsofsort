using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MethodVklucheniya
{

    class AddParams
    {
        public int a, b;

        public AddParams(int numb1,int numb2)
        {
            a = numb1;
            b = numb2;
        }
    }

    class Program
    {
        private static AutoResetEvent waitHandle = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            Console.WriteLine("ID of thread in Add() : {0}", Thread.CurrentThread.ManagedThreadId);
            AddParams ap = new AddParams(10, 10);
            Thread t = new Thread(new ParameterizedThreadStart(Add));
            t.Start(ap);

            waitHandle.WaitOne();
            Console.WriteLine("Other thread is done");
        }

        static void Add(object data)
        {
            if (data is AddParams)
            {
                Console.WriteLine("ID of thread in Add() : {0}", Thread.CurrentThread.ManagedThreadId);
                AddParams ap = (AddParams)data;
                Console.WriteLine("{0} + {1} is {2}", ap.a, ap.b, ap.a + ap.b);
                waitHandle.Set();
            }
        }
    }
}
