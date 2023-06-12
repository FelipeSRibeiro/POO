using agenciaBancaria.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace agenciaBancaria.Data.Context
{
    public class DataContext: DbContext
    {
        protected string DbPath { get; }
        public DataContext(){
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "agenciaBancria.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");
        
        public DbSet<People> Peoples{get; set;}

        public DbSet<Account> Accounts {get; set;}
            
        
    }
}