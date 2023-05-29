using Aula12_Entity.Data.Types;
using Aula12_Entity.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aula12_Entity.Data.Context
{
    public class DataContext : DbContext
    {
        protected string DbPath { get; }
        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "gestaoclick.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlite($"Data Source={DbPath}");
        
        public DbSet<Fornecedor> DbSetFornecedor { get; set; }
        public DbSet<Produto> DbSetProduto { get; set; }
        public DbSet<Endereco> DbSetEndereco { get; set; }
    }
}