using System;
using Ecom.CatalogService.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Ecom.Catalog.Service.Data
{
	public class CatalogContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

        public string DbPath { get; set; }

        public CatalogContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "catalog.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
            base.OnConfiguring(optionsBuilder);
        }
    }
}