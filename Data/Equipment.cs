using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Equipment
    {
        [Key]
        [StringLength(40, MinimumLength = 1)]
        public string Name { get; set; }

        [Required] [Range(0, int.MaxValue)] public int Cost { get; set; }

        [Required] public Category Category { get; set; }

        [Required] public int Strength { get; set; }

        [Required] public int Intelligence { get; set; }

        [Required] public int Agility { get; set; }
    }

    public enum Category
    {
        Head,
        Chest,
        Hand,
        Feet,
        Ring,
        Necklace
    }
}