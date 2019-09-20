using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class WorkItem
    {
        private BaseState _state = null;
        public WorkItem(BaseState state)
        {
            _state = state;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string State { get; set; }

        public void setState(BaseState state)
        {
            Console.WriteLine("Set State to: " + state.GetType().Name);

            _state = state;
            _state.SetWorkItem(this);
        }

        public void PrintState()
        {
            this._state.PrintState();
        }
    }
}
