using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(2012, 12, 12, 0, 0, 0);

            IoC.Map<IClock>(typeof(MyClock));
            DependencyInjection instance = IoC.Resolve<DependencyInjection>(typeof(IClock));
            instance = IoC.Resolve<DependencyInjection>(typeof(IClock), typeof(int));
            bool result = instance.IsValid(dob);
            Console.WriteLine("Result is:" + result);

            //DependencyInjection instance1 = new DependencyInjection(iocClock);
            //result = instance1.IsValid(dob);
            //Console.WriteLine("Result is:" + result);

            IClock manualClock = new MyClock();
            DependencyInjection instance2 = new DependencyInjection(manualClock);
            result = instance2.IsValid(dob);
            Console.WriteLine("Result is:" + result);

            Console.ReadLine();
        }
    }
}
