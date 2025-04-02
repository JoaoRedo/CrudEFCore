using Microsoft.EntityFrameworkCore;
using CrudEF.Models;

namespace CrudEF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
} 