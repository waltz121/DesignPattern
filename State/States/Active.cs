using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class Active : BaseState
    {
        public override void PrintState()
        {
            Console.WriteLine("the current State is Active");
        }
    }
}
