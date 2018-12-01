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
        public DependencyInjection(IClock clock)
        {
            this.clock = clock;
        }

        public bool IsValid(DateTime instance)
        {
            //return instance > DateTime.Now.Date;
            return instance < clock.Date;
        }
    }
}
