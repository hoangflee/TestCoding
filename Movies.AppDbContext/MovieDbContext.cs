using Microsoft.EntityFrameworkCore;
using Movies.Entities;

namespace Movies.AppDbContext
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(x => x.ToTable("Users"));
            modelBuilder.Entity<Entities.Movies>(x => x.ToTable("Movies"));
            modelBuilder.Entity<UserLikeMovies>(x => x.ToTable("UserLikeMovies"));

            modelBuilder.Seed(); //Data seeding

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Entities.Movies> Movies { get; set; }
        public DbSet<UserLikeMovies> UserLikeMovies { get; set; }
    }
}
