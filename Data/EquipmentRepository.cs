using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class EquipmentRepository : IEquipmentRepository
    {
        public Equipment Create(Equipment equipment)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Equipment.Add(equipment);
            ctx.SaveChanges();
            return equipment;
        }

        public bool Delete(int id)
        {
            using var ctx = new NinjaManagerContext();
            var toRemove = ctx.Equipment.Find(id);

            if (toRemove == null) return false;

            ctx.Equipment.Remove(toRemove);
            ctx.SaveChanges();

            return true;
        }

        public List<Equipment> GetAll()
        {
            using var ctx = new NinjaManagerContext();
            return ctx.Equipment.ToList();
        }

        public Equipment GetOne(int id)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.Equipment.FirstOrDefault(m => m.Id == id);
        }

        public Equipment Update(Equipment equipment)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Attach(equipment);
            ctx.Equipment.Update(equipment);
            ctx.SaveChanges();
            return equipment;
        }
    }
}
