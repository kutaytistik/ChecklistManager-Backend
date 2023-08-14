using Entiities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITemplateService
    {
        List<Template> GetAll();
        Template GetById(int id);

        void Add(Template template);
        void Update(Template template);
        void Delete(Template template);

        void UpdateCheckbox(ChecklistItem item);
    }
}
