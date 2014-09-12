using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoGallery.Model
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public string FilePath { get; set; }

        // EXIF
        public int Width { get; set; }
        public int Height { get; set; }
        public DateTime CreationDate { get; set; }
        public double Speed { get; set; }
        public double Aperture { get; set; }
        public int Focal { get; set; }
        public GeoCoordinates Location { get; set; }

        // FK
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

        public int DeviceId { get; set; }
        public virtual Device Device { get; set; }
    }
}
