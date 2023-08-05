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
    public class TemplateManager : ITemplateService
    {
        ITemplateDal _templateDal;
        public TemplateManager(ITemplateDal templateDal)
        {
            _templateDal = templateDal;
        }
        public void Add(Template template)
        {
            _templateDal.Add(template);
        }

        public void Delete(Template template)
        {
            _templateDal.Delete(template);
        }

        public List<Template> GetAll()
        {
            return _templateDal.GetAll();
        }

        public Template GetById(int id)
        {
            return _templateDal.GetById(t=>t.TemplateId==id);
        }

        public void Update(Template template)
        {
            _templateDal.Update(template);
        }
    }
}
