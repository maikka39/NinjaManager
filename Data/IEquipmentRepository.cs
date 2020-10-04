using System.Collections.Generic;

namespace Data {
    public interface IEquipmentRepository {
        List<Equipment> GetAll ();
        Equipment GetOne (string name);
        bool Delete (int id);
        Equipment Update (Equipment equipment);
        Equipment Create (Equipment equipment);
    }
}