using Data;

namespace Web.Models
{
    public class EquipmentEditViewModel : EquipmentCreateViewModel
    {
        public int Id { get; set; }

        public EquipmentEditViewModel(Equipment equipment) : base(equipment)
        {
            Id = equipment.Id;
        }
    }
}
