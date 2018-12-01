using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public static class IoC
    {
        private static Dictionary<Type, object> container = 
            new Dictionary<Type, object>(); 
        
        public static void Map<T>(Type instanceType)
        {
            //var parameters = instanceType.GetConstructors()
            //    .Select(p => ResolveType(p.GetType())).ToArray();
            T a = (T)Activator.CreateInstance(instanceType);
            container.Add(typeof(T), a);
        }        

        public static T Resolve<T>(params Type[] paramTypes)
        {
            object[] parameters = paramTypes.Select(p => container.ContainsKey(p) ? container[p] : ResolveType(p)).ToArray();
            
            return (T)Activator.CreateInstance(typeof(T), parameters);
        }

        private static object ResolveType(Type p)
        {
            return Activator.CreateInstance(p);
        }
    }
}
