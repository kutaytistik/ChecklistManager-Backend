using Business.Abstract;
using DataAccess.Abstract;
using Entiities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ChecklistItemManager:IChecklistItemService
    {
        IChecklistItemDal _checklistItemDal;
        public ChecklistItemManager(IChecklistItemDal checklistItemDal)
        {
            _checklistItemDal = checklistItemDal;
        }
        public void Add(ChecklistItem checklistItem)
        {
            _checklistItemDal.Add(checklistItem);
        }

        public void Delete(ChecklistItem checklistItem)
        {
            _checklistItemDal.Delete(checklistItem);
        }

        public List<ChecklistItem> GetAll()
        {
            return _checklistItemDal.GetAll();
        }

        public ChecklistItem GetById(int id)
        {
            return _checklistItemDal.GetById( c=> c.ChecklistItemId == id);
        }

        public void Update(ChecklistItem checklistItem)
        {
            _checklistItemDal.Update(checklistItem);
        }
    }
}
