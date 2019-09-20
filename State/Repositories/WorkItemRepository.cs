using DataAccess;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace State.Repositories
{
    public class WorkItemRepository : IRepository<DataAccess.WorkItem>
    {
        DesignPatternDBEntities DBEntities;
        public WorkItemRepository(DesignPatternDBEntities dBEntities)
        {
            DBEntities = dBEntities;
        }
        public void Add(DataAccess.WorkItem newEntity)
        {
            DBEntities.WorkItems.Add(newEntity);
        }

        public IQueryable<DataAccess.WorkItem> Find(Expression<Func<DataAccess.WorkItem, bool>> predicate)
        {
            var workItems = DBEntities.WorkItems.Where(predicate);
            return workItems;
        }

        public IQueryable<DataAccess.WorkItem> FindAll()
        {
            return DBEntities.WorkItems;
        }

        public DataAccess.WorkItem FindById(int id)
        {
            return DBEntities.WorkItems.Where(x => x.Id == id).SingleOrDefault();
        }

        public void Remove(DataAccess.WorkItem entity)
        {
            DBEntities.WorkItems.Remove(entity);
        }
    }
}
