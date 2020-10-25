using Data;

namespace Web.Models
{
    public class EquipmentIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Cost { get; set; }
        public Category Category { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }

        public EquipmentIndexViewModel(Equipment equipment)
        {
            Id = equipment.Id;
            Name = equipment.Name;
            Description = equipment.Description;
            Cost = equipment.Cost;
            ImageUrl = equipment.ImageUrl;
            Category = equipment.Category;
            Strength = equipment.Strength;
            Intelligence = equipment.Intelligence;
            Agility = equipment.Agility;
        }
    }
}
