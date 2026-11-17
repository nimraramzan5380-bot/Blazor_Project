using Microsoft.EntityFrameworkCore;
using StudentCRUDapp.Model;

namespace StudentCRUDapp.Data
{
    public class AppDbContexts : DbContext
    {
        public AppDbContexts( DbContextOptions<AppDbContexts> options ) : base( options )
        {
                
        }
        public DbSet<Student> Students { get; set; }
    }
}
