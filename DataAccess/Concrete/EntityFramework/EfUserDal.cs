using DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entiities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        ChecklistManagerContext _checklistManagerContext;

        public EfUserDal(ChecklistManagerContext checklistManagerContext)
        {
            _checklistManagerContext = checklistManagerContext;
        }

        public void Add(User entity)
        {

            var addedEntity = _checklistManagerContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _checklistManagerContext.SaveChanges();

        }

        public void Delete(User entity)
        {

            var deletedEntity = _checklistManagerContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _checklistManagerContext.SaveChanges();

        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {

            return filter == null ? _checklistManagerContext.Set<User>().ToList() : _checklistManagerContext.Set<User>().Where(filter).ToList();

        }

        public User GetById(Expression<Func<User, bool>> filter)
        {

            return _checklistManagerContext.Set<User>().SingleOrDefault(filter);

        }

        public void Update(User entity)
        {

            var updatedEntity = _checklistManagerContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _checklistManagerContext.SaveChanges();
        }
    }
}
