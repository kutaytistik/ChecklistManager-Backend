using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChecklistDal : IChecklistDal
    {
        ChecklistManagerContext _checklistManagerContext;

        public EfChecklistDal(ChecklistManagerContext checklistManagerContext)
        {
            _checklistManagerContext = checklistManagerContext;
        }
        public void Add(Checklist entity)
        {

            var addedEntity = _checklistManagerContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _checklistManagerContext.SaveChanges();

        }

        public void Delete(Checklist entity)
        {

            var deletedEntity = _checklistManagerContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _checklistManagerContext.SaveChanges();

        }

        public List<Checklist> GetAll(Expression<Func<Checklist, bool>> filter = null)
        {


            return filter == null ? _checklistManagerContext.Set<Checklist>().ToList() : _checklistManagerContext.Set<Checklist>().Where(filter).ToList();


        }


        public Checklist GetById(Expression<Func<Checklist, bool>> filter)
        {
            return _checklistManagerContext.Set<Checklist>().SingleOrDefault(filter);
        }

        public void Update(Checklist entity)
        {

            var updatedEntity = _checklistManagerContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _checklistManagerContext.SaveChanges();

        }

        public void UpdateCheckbox(ChecklistItem item)
        {
            var existingItem = _checklistManagerContext.Entry(item);
            existingItem.Property(x => x.IsCompleted).IsModified = true;
            _checklistManagerContext.SaveChanges();
        }
    }
}
