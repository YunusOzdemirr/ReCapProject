﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCarProjectContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rentals> Rentals { get; set; }
        public DbSet<CarImage> CarImages{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ReCapProject;User=sa;Password=Password123@jkl#;");
        }
      
    }
}
