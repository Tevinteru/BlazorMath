using BlazorMath.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMath.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) 
        {
        }

        public DbSet<Student> Students { get; set; }    
    }
}
