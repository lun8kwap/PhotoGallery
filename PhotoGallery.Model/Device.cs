using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoGallery.Model
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }

        // FK
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
