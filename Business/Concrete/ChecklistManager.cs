using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ChecklistManager:IChecklistService
    {
        IChecklistDal _checklistDal;
        public ChecklistManager(IChecklistDal checklistDal)
        {
            _checklistDal = checklistDal;
        }
        public void Add(Checklist checklist)
        {
            _checklistDal.Add(checklist);
        }

        public void Delete(Checklist checklist)
        {
            _checklistDal.Delete(checklist);
        }

        public List<Checklist> GetAll()
        {
            return _checklistDal.GetAll();
        }

        public Checklist GetById(int id)
        {
            return _checklistDal.GetById(c => c.ChecklistId == id);
        }

        public void Update(Checklist checklist)
        {
            _checklistDal.Update(checklist);
        }
    }
}
