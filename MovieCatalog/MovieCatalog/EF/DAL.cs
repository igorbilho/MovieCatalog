using MovieCatalog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieCatalog.EF
{
    public class DAL : DbContext
    {
        public DAL() : base("MovieConnectionString")
        {

        }

        public DbSet<Movie> movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Movie>().HasKey(x => x.mv_id);
        }
    }
}