using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCarProjectContext : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<CarImage> CarImages{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
        }
      
    }
}
