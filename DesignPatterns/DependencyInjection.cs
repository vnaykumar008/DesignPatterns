using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DependencyInjection
    {
        private readonly IClock clock;
        private int a;
        public DependencyInjection(IClock clock)
        {
            this.clock = clock;
        }

        public DependencyInjection(IClock clock, int a)
        {
            this.clock = clock;
            this.a = a;
        }

        public bool IsValid(DateTime instance)
        {
            //return instance > DateTime.Now.Date;
            return instance < clock.Date;
        }
    }
}
