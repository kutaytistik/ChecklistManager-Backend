using Entiities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IChecklistItemService
    {
        List<ChecklistItem> GetAll();
        ChecklistItem GetById(int id);

        void Add(ChecklistItem item);
        void Update(ChecklistItem item);
        void Delete(ChecklistItem item);
    }
}
