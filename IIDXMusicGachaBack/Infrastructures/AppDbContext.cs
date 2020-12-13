using IIDXMusicGachaBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace IIDXMusicGachaBack.Infrastructures
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="options"></param>
        public AppDbContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// Songs table
        /// </summary>
        public DbSet<Song> Songs { get; set; }
    }
}
