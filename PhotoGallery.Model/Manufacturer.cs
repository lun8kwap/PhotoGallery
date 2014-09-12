using System.Collections.Generic;

namespace PhotoGallery.Model
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
