using App.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EntityFramework.EntityFramework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDB")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeComment> RecipeComments { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }
    }
}
