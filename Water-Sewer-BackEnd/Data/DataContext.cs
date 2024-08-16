using Microsoft.EntityFrameworkCore;
using Water_Sewer_BackEnd.Entities;

namespace Water_Sewer_BackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ContactRequest> ContactRequests { get; set; }
    }
}
