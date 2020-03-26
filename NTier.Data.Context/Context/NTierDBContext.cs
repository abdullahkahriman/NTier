using Microsoft.EntityFrameworkCore;
using NTier.Data.Model.Entity;
using NTier.Data.Model.System;

namespace NTier.Data.Context.Context
{
    public class NTierDBContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleSystemAction> RoleSystemAction { get; set; }
        public DbSet<SystemAction> SystemAction { get; set; }

        public NTierDBContext(DbContextOptions<NTierDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}