using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_1
{
    class SystemClock
    {
        private long clock;
        public long Clock { 
            get 
            { 
                return clock;
            }
            private set
            {
                clock = value;
            }
        }

        public void WorkingCycle()
        {
            Clock++;
        }

        public void Clear()
        {
            Clock = 0;
        }
    }
}