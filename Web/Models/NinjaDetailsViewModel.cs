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

        public Equipment Head { get; }
        public Equipment Chest { get; }
        public Equipment Hand { get; }
        public Equipment Feet { get; }
        public Equipment Ring { get; }
        public Equipment Necklace { get; }


        public NinjaDetailsViewModel(Ninja ninja, IEnumerable<Equipment> equipments)
        {
            Id = ninja.Id;
            Name = ninja.Name;
            Gold = ninja.Gold;
            SkinUrl = ninja.SkinUrl;

            _equipments = equipments;

            Head = GetEquipment(Category.Head);
            Chest = GetEquipment(Category.Chest);
            Hand = GetEquipment(Category.Hand);
            Feet = GetEquipment(Category.Feet);
            Ring = GetEquipment(Category.Ring);
            Necklace = GetEquipment(Category.Necklace);
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
