using Data;

namespace Web.Models
{
    public class EquipmentIndexViewModel
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string ImageUrl { get; }
        public int Cost { get; }
        public Category Category { get; }
        public int Strength { get; }
        public int Intelligence { get; }
        public int Agility { get; }
        
        public int NinjaId { get; }

        public EquipmentIndexViewModel(Equipment equipment, int ninjaId)
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

            NinjaId = ninjaId;
        }
    }
}
