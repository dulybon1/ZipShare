using System.ComponentModel.DataAnnotations;

namespace ZipShare.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string ItemBrand { get; set; }
        public string ItemSerialNumber { get; set; }

    }
}