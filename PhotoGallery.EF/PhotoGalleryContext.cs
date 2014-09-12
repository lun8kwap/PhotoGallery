using PhotoGallery.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PhotoGallery.EF
{
    public class PhotoGalleryContext : DbContext
    {
        public PhotoGalleryContext()
            : base("PhotoGalleryContext")
        {
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
