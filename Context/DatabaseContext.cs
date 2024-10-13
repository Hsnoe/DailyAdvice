using DailyAdvice.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DailyAdvice.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        // Entity'leri DbSet ile tanımla
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<TvShow> TvShows { get; set; }

        // OnConfiguring metodu PostgreSQL bağlantısını yapılandırmak için kullanılabilir




    }
}
