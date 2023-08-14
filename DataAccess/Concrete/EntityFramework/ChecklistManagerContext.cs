
using DataAccess.Abstract;
using Entiities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ChecklistManagerContext : DbContext
    {
        public ChecklistManagerContext(DbContextOptions<ChecklistManagerContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies();


        }


        public DbSet<ChecklistItem> ChecklistItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
    }
}
