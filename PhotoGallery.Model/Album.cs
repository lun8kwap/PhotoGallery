using System;
using System.Collections.Generic;

namespace PhotoGallery.Model
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }
    }
}
