using System;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ef_core.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CategoryEntity> categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database =ef_db;uid=root;pwd=root;");
        }
    }
}
