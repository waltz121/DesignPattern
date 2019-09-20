using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class BaseState
    {
        WorkItem workItem;
        public void SetWorkItem(WorkItem workItem)
        {
            this.workItem = workItem;
        }
        public abstract void PrintState();
    }
}
