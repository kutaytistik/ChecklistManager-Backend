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

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTemplateDal : ITemplateDal
    {
        ChecklistManagerContext _checklistManagerContext;
        
        public EfTemplateDal(ChecklistManagerContext checklistManagerContext)
        {
            _checklistManagerContext = checklistManagerContext;
        }
        public void Add(Template entity)
        {

            var addedEntity = _checklistManagerContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _checklistManagerContext.SaveChanges();

        }

        public void Delete(Template entity)
        {

            var deletedEntity = _checklistManagerContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _checklistManagerContext.SaveChanges();

        }

        public List<Template> GetAll(Expression<Func<Template, bool>> filter = null)
        {


            return filter == null ? _checklistManagerContext.Set<Template>().ToList() : _checklistManagerContext.Set<Template>().Where(filter).ToList();


        }


        public Template GetById(Expression<Func<Template, bool>> filter)
        {

            return _checklistManagerContext.Set<Template>().SingleOrDefault(filter);

        }

        public void Update(Template entity)
        {

            var updatedEntity = _checklistManagerContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _checklistManagerContext.SaveChanges();

        }
    }
}
