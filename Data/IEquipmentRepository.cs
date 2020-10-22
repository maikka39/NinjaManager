using System.Collections.Generic;

namespace Data
{
    public interface IEquipmentRepository
    {
        List<Equipment> GetAll();
        Equipment GetOne(int id);
        bool Delete(int id);
        Equipment Update(Equipment equipment);
        Equipment Create(Equipment equipment);
    }
}
