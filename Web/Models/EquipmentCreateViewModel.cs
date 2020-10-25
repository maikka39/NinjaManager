using System;
using System.Collections;
using Data;

namespace Web.Models
{
    public class EquipmentCreateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Cost { get; set; }
        public Category Category { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }

        public EquipmentCreateViewModel()
        {
            
        }

        public EquipmentCreateViewModel(Equipment equipment)
        {
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
