﻿using EMarketDemo.DataAccess.Concrete.EntityFramework.Mapping;
using EMarketDemo.Entities.Concrete;
using System.Data.Entity;

namespace EMarketDemo.DataAccess.Concrete.EntityFramework
{
    public class EMarketContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
