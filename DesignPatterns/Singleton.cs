using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SingletonV1
    {
        private static object mutex = new object();
        private static SingletonV1 instance;
        private SingletonV1()
        {

        }

        public static SingletonV1 Instace()
        {
            if (instance == null)
            {
                lock (mutex)
                {
                    if (instance == null)
                    {
                        instance = new SingletonV1();
                    }
                }
            }
            return instance;
        }

        public void DoSomething()
        {

        }
    }

    public class SingletonV2
    {
        private static readonly SingletonV2 instance = new SingletonV2();
        private SingletonV2()
        {

        }

        public static SingletonV2 Instace { get { return instance; } }

        public void DoSomething()
        {

        }
    }

    public class SingletonV3
    {
        private static class SingletonInstanceHolder
        {
            internal static readonly SingletonV3 instance = new SingletonV3();
            static SingletonInstanceHolder() { }
        }

        private SingletonV3()
        {

        }

        public static SingletonV3 Instace { get { return SingletonInstanceHolder.instance; } }

        public void DoSomething()
        {

        }
    }

    public class SingletonV4
    {
        private static readonly Lazy<SingletonV4> instance = new Lazy<SingletonV4>(() => new SingletonV4());
        private SingletonV4()
        {

        }

        public static SingletonV4 Instace { get { return instance.Value; } }

        public void DoSomething()
        {

        }
    }
}
