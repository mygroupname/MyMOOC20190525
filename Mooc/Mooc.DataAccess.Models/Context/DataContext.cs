using Mooc.DataAccess.Models.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace Mooc.DataAccess.Models.Context
{
    public class DataContext: DbContext
    {
        public DataContext() : base(GetConnectionString())
        {
        }

        private static string GetConnectionString()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["ConnectionString"];
            return settings.ConnectionString;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<User>().ToTable("Users");
            //modelBuilder.Entity<Subject>().ToTable("Subjects");
            // modelBuilder.Entity<User>().Property(m => m.UserName).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<User>().Property(m => m.Date).HasColumnType("date");
            //modelBuilder.Entity<User>().Property(m => m.Text).HasMaxLength(40).IsRequired();
            //modelBuilder.Entity<User>().HasRequired(m => m.MenuCard).WithMany(c => c.Menus).HasForeignKey(m => m.MenuCardId);
            //modelBuilder.Entity<User>().Property(c => c.Text).HasMaxLength(30).IsRequired();
            //modelBuilder.Entity<User>().HasMany(c => c.Menus).WithRequired().WillCascadeOnDelete();
        }
    }
}
