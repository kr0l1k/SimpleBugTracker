using Microsoft.EntityFrameworkCore;
using ModelsRepository;
using System;

namespace DBReprository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<BugHistory> BugsHistory { get; set; }
        
    }
}
