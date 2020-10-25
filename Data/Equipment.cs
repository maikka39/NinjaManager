using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Equipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(40, MinimumLength = 1)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(256, MinimumLength = 1)]
        public string Description { get; set; }

        [Required]
        [StringLength(512, MinimumLength = 3)]
        public string ImageUrl { get; set; }

        [Required] [Range(0, int.MaxValue)] public int Cost { get; set; }

        [Required] public Category Category { get; set; }

        [Required] public int Strength { get; set; }

        [Required] public int Intelligence { get; set; }

        [Required] public int Agility { get; set; }
        
        public ICollection<NinjaEquipment> Ninjas { get; set; }
    }

    public enum Category
    {
        Helmet,
        Chestplate,
        Leggings,
        Boots,
        Sword,
        Potion
    }
}
