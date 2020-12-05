
using Microsoft.EntityFrameworkCore;

namespace PhotoCore.DataAccess.Models
{
    public class PhotoCoreContext : DbContext
    {
        public PhotoCoreContext(DbContextOptions<PhotoCoreContext> options) : base(options)
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}