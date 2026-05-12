using Microsoft.EntityFrameworkCore;
using FragTracker.Models;

namespace FragTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<ProPlayer> ProPlayers { get; set; }
    }
}