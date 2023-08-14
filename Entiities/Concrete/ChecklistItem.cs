using Entiities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ChecklistItem : IEntity
    {
        //Checklist içerisindeki her bir ögeyi temsil eder
        [Key]
        public int ChecklistItemId { get; set; }
        public string Content { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int? ChecklistId { get; set; }
        public int? TemplateId { get; set; }
        public virtual Template? Template { get; set; }
        public virtual Checklist? Checklist { get; set; }

    }
}
