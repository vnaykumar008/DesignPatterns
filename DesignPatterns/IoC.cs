using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class IoC
    {
        //private static Dictionary<Type, Func<Object>> container;  
        public static T Bind<T>(Type instanceType)
        {
            T a = (T)Activator.CreateInstance(instanceType);
            return a;
            //container.Add(instanceType, () => a);
        }

        //public static object Resolve(Type type)
        //{
        //    return container[type].Invoke();
        //}
    }
}
