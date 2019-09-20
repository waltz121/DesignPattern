using DataAccess;
using State.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class Resolved : BaseState
    {
        IRepository<DataAccess.WorkItem> workitemRepository;
        public override void PrintState()
        {
            setCurrentState();

            Console.WriteLine("Current WorkItem Id: " + workItem.Id);
            Console.WriteLine("Current Title: " + workItem.Title);
            Console.WriteLine("Current Description: " + workItem.Description);
            Console.WriteLine("Current State: " + workItem.State);
        }

        void setCurrentState()
        {
            using (DesignPatternDBEntities dBEntities = new DesignPatternDBEntities())
            {
                workitemRepository = new WorkItemRepository(dBEntities);
                var DAworkItem = workitemRepository.FindById(7);
                workItem.Id = DAworkItem.Id;
                workItem.State = DAworkItem.State;
                workItem.Title = DAworkItem.Title;
                workItem.Description = DAworkItem.Description;
            }
        }
    }
}
