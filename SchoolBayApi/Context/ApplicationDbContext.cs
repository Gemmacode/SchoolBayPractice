using Microsoft.EntityFrameworkCore;
using SchoolBayApi.Models;

namespace SchoolBayApi.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }    
    }
}
