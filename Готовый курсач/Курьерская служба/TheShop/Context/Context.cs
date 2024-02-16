using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Models;

namespace TheShop.Context
{
	public class ProjectContext : DbContext
	{
		/*public ProjectContext() : base("conString")
		{
			Database.SetInitializer<ProjectContext>(new MigrateDatabaseToLatestVersion<ProjectContext, Configuration>());
		}*/
		public ProjectContext() : base("conString")
		{

		}
		public DbSet<Provider> Providers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<Department> Departments { get; set; } 
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Unit> Units { get; set; }
		public DbSet<Manufacturer> Manufacturers { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Provider>().HasMany(o => o.Products).WithRequired(o => o.Provider).HasForeignKey(o => o.ProviderId).WillCascadeOnDelete();
			modelBuilder.Entity<Unit>().HasMany(o => o.Products).WithRequired(o => o.Unit).HasForeignKey(o => o.UnitId).WillCascadeOnDelete();
			modelBuilder.Entity<Manufacturer>().HasMany(o => o.Products).WithRequired(o => o.Manufacturer).HasForeignKey(o => o.ManufacturerId).WillCascadeOnDelete();
			modelBuilder.Entity<Group>().HasMany(o => o.Products).WithRequired(o => o.Group).HasForeignKey(o => o.GroupId).WillCascadeOnDelete();
			modelBuilder.Entity<Group>().HasMany(o => o.Departments).WithRequired(o => o.Group).HasForeignKey(o => o.GroupId).WillCascadeOnDelete();
			modelBuilder.Entity<Department>().HasMany(o => o.Employees).WithRequired(o => o.Department).HasForeignKey(o => o.DepartmentId).WillCascadeOnDelete();
			modelBuilder.Entity<Post>().HasMany(o => o.Employees).WithRequired(o => o.Post).HasForeignKey(o => o.PostId).WillCascadeOnDelete();
		}

	}
	internal sealed class Configuration : DbMigrationsConfiguration<ProjectContext>
	{

		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			ContextKey = "conString";
			AutomaticMigrationDataLossAllowed = true;
		}

		protected override void Seed(ProjectContext context)
		{
			try
			{

				base.Seed(context);
			}
			catch (Exception exp)
			{

			}
		}
	}
}
