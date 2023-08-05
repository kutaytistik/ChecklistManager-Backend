using Entiities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Template : IEntity
    {
        //Hazır templateleri temsil eder
        [Key]
        public int TemplateId { get; set; }
        public string Title { get; set; }

        public virtual List<ChecklistItem>? Items { get; set; }
    }
}
