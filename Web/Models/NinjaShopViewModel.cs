using System.Collections.Generic;
using System.Linq;
using Data;

namespace Web.Models
{
    public class NinjaShopViewModel
    {
        public int Id { get; }
        public int Gold { get; }
        public List<Equipment> Equipments { get; }

        public NinjaShopViewModel(Ninja ninja, List<Equipment> equipments)
        {
            Id = ninja.Id;
            Gold = ninja.Gold;
            Equipments = equipments;
        }

        public bool HasCategory(Category category)
        {
            return Equipments.Any(equipment => equipment.Category == category);
        }
    }
}
