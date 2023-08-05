using ChecklistManager.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecklistManager.Entities.Concrete
{
    public class TodoItem : IEntity
    {
        public int TodoId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? UpdatedByUserId { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int? DeletedByUserId { get; set; }
    }
}
