namespace SzakmakApi.Data;
using Microsoft.EntityFrameworkCore;
using SzakmakApi.Models;
{
    public class versenyzoDbContext : DbContext
    {
    public versenyzoDbContext(DbContextOptions<versenyzoDbContext> options) : base(options) { }

    public DbSet<orszag> orszagok {  get; set; }
    
    public DbSet<szakma> szakmak {  get; set; }

    public DbSet<versenyzo> versenyzok { get; set; }

    }
}
