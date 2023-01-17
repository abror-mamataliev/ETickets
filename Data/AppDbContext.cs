using ETickets.Models;
using Microsoft.EntityFrameworkCore;

namespace ETickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<ActorMovie>().HasOne(am => am.Movie).WithMany(m => m.ActorsMovies).HasForeignKey(am => am.MovieId);
            modelBuilder.Entity<ActorMovie>().HasOne(am => am.Actor).WithMany(a => a.ActorsMovies).HasForeignKey(am => am.MovieId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorsMovies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
