using System.Collections.Generic;

namespace Data
{
    public interface INinjaRepository
    {
        List<Ninja> GetAll();
        Ninja GetOne(int id);
        IEnumerable<Equipment> GetEquipmentsFromNinja(Ninja ninja);
        bool Delete(int id);
        Ninja Update(Ninja ninja);
        Ninja UpdateEquipments(Ninja ninja, List<Equipment> equipments);
        Ninja Create(Ninja ninja);
    }
}
