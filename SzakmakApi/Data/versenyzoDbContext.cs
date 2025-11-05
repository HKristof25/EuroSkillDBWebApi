using Microsoft.EntityFrameworkCore;
using SzakmakApi.Models;

namespace SzakmakApi.Data
{
    public class versenyzoDbContext : DbContext
    {
    public versenyzoDbContext(DbContextOptions<versenyzoDbContext> options) : base(options) { }

    public DbSet<orszag> orszagok {  get; set; }
    
    public DbSet<szakma> szakmak {  get; set; }

    public DbSet<versenyzo> versenyzok { get; set; }

    }
}
