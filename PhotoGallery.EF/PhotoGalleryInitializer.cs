using PhotoGallery.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Management;

namespace PhotoGallery.EF
{
    public class PhotoGalleryInitializer : DropCreateDatabaseAlways<PhotoGalleryContext>
    //public class PhotoGalleryInitializer : DropCreateDatabaseIfModelChanges<PhotoGalleryContext>
    {
        protected override void Seed(PhotoGalleryContext context)
        {
            // Membership
            ApplicationServices.InstallServices(SqlFeatures.Membership | SqlFeatures.RoleManager); 

            // Insert fake users
            var albums = new List<Album>
            {
                new Album{Title="Vacances",Description="Lors de l'été 2014",CreationDate=DateTime.Now.AddDays(-1)}
            };

            albums.ForEach(u => context.Albums.Add(u));
            context.SaveChanges();
        }
    }
}
