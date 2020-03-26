using Microsoft.EntityFrameworkCore;
using NTier.Data.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.Data.Context.Context
{
    public class NTierDBContext : DbContext
    {
        public DbSet<Book> Book { get; set; }

        public NTierDBContext(DbContextOptions<NTierDBContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}