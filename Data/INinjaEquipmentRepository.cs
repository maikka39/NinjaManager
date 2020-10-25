using System.Collections.Generic;

namespace Data
{
    public interface INinjaEquipmentRepository
    {
        List<NinjaEquipment> GetAll();
        List<Equipment> GetEquipmentFromNinja(Ninja ninja);
        public List<Ninja> GetNinjaFromEquipment(Equipment equipment);
        bool Delete(int ninjaId, int equipmentId);
        NinjaEquipment Update(NinjaEquipment ninjaEquipment);
        NinjaEquipment Create(NinjaEquipment ninjaEquipment);
    }
}