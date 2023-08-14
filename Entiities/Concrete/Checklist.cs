using Entiities.Abstract;
using Entiities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Checklist : IEntity
    {
        //Kullanıcının oluşturabileceği checklistleri temsil eder
        [Key]
        public int ChecklistId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public  virtual List<ChecklistItem>? Items { get; set; }

    }
}
