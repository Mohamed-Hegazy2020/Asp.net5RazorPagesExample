using Asp.net5RazorPagesExample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.net5RazorPagesExample.ModelsView;

namespace Asp.net5RazorPagesExample.Data
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CompanyMainData> CompanyMainDatas { get; set; }
        public DbSet<Service> Services { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<CompanyMainData>().ToTable("CompanyMainData");
            modelBuilder.Entity<Service>().ToTable("Service");
        }


        //public DbSet<Asp.net5RazorPagesExample.ModelsView.CompanyMainDataMV> CompanyMainDataMV { get; set; }
        //public DbSet<Asp.net5RazorPagesExample.ModelsView.CompanyMainDataMV> CompanyMainDataMV { get; set; }
        //public DbSet<Asp.net5RazorPagesExample.ModelsView.CompanyMainDataMV> CompanyMainDataMV { get; set; }
    }
}
