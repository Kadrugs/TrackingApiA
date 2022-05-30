using Microsoft.EntityFrameworkCore;
using TrackingApiA.Models;

namespace TrackingApiA.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext (DbContextOptions<IssueDbContext> options) :base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
