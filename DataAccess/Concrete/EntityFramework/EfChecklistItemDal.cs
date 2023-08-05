using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entiities.Abstract;
using Entiities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChecklistItemDal : IChecklistItemDal
    {

        ChecklistManagerContext _checklistManagerContext;

        public EfChecklistItemDal(ChecklistManagerContext checklistManagerContext)
        {
            _checklistManagerContext = checklistManagerContext;
        }
        public void Add(ChecklistItem entity)
        {

            var addedEntity = _checklistManagerContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _checklistManagerContext.SaveChanges();

        }

        public void Delete(ChecklistItem entity)
        {

            var deletedEntity = _checklistManagerContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _checklistManagerContext.SaveChanges();

        }

        public List<ChecklistItem> GetAll(Expression<Func<ChecklistItem, bool>> filter = null)
        {

            return filter == null ? _checklistManagerContext.Set<ChecklistItem>().ToList() : _checklistManagerContext.Set<ChecklistItem>().Where(filter).ToList();


        }


        public ChecklistItem GetById(Expression<Func<ChecklistItem, bool>> filter)
        {

            return _checklistManagerContext.Set<ChecklistItem>().SingleOrDefault(filter);

        }

        public void Update(ChecklistItem entity)
        {

            var updatedEntity = _checklistManagerContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _checklistManagerContext.SaveChanges();

        }
    }
}
