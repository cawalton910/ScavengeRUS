using Microsoft.EntityFrameworkCore;
using ScavengeRUS.Models.Entities;
using System;

namespace ScavengeRUS.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Player> Players => Set<Player>();
        public DbSet<Hunt> Hunt => Set<Hunt>();
        public DbSet<Admin> Admin => Set<Admin>();
    }
}
