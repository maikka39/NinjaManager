using System.Collections.Generic;
using System.Linq;
using Data;

namespace Web.Models
{
    public class NinjaDetailsViewModel
    {
        public int Id { get; }
        public string Name { get; }
        public int Gold { get; }
        public string SkinUrl { get; }

        private IEnumerable<Equipment> _equipments;

        public Equipment Helmet { get; }
        public Equipment Chestplate { get; }
        public Equipment Leggings { get; }
        public Equipment Boots { get; }
        public Equipment Sword { get; }
        public Equipment Potion { get; }


        public NinjaDetailsViewModel(Ninja ninja, IEnumerable<Equipment> equipments)
        {
            Id = ninja.Id;
            Name = ninja.Name;
            Gold = ninja.Gold;
            
            SkinUrl = SkinUrl != null ? ninja.SkinUrl : "/images/skins/steve.png";

            _equipments = equipments;

            Helmet = GetEquipment(Category.Helmet);
            Chestplate = GetEquipment(Category.Chestplate);
            Leggings = GetEquipment(Category.Leggings);
            Boots = GetEquipment(Category.Boots);
            Sword = GetEquipment(Category.Sword);
            Potion = GetEquipment(Category.Potion);
        }

        private Equipment GetEquipment(Category category)
        {
            return _equipments.FirstOrDefault(equipment => equipment.Category == category);
        }

        public int GetTotalGold()
        {
            return Gold + GetGearValue();
        }
        public int GetGearValue()
        {
            return _equipments.Sum(equipment => equipment.Cost);
        }

        public int GetTotalStrength()
        {
            return _equipments.Sum(equipment => equipment.Strength);
        }
        
        public int GetTotalAgility()
        {
            return _equipments.Sum(equipment => equipment.Agility);
        }
        
        public int GetTotalIntelligence()
        {
            return _equipments.Sum(equipment => equipment.Intelligence);
        }
    }
}
