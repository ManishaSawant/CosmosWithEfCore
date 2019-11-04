using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace CosmosWithEfCore.Models
{
    public class BookmarksDbContext : DbContext
    {
        public BookmarksDbContext(DbContextOptions options) : base(options)
        {
        }
        protected BookmarksDbContext()
        {
        }
        public DbSet<Bookmark> Bookmarks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Bookmark>();
            //  var bookmarks = modelBuilder.Entity<Bookmark>().Metadata;
            //bookmarks.CosmosDb().CollectionName = nameof(Bookmarks);

            modelBuilder.Entity<Bookmark>().Property(p => p.Id).HasValueGenerator<GuidValueGenerator>();
        }
    }
}