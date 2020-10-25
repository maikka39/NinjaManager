using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class EquipmentRepository : IEquipmentRepository
    {
        public Equipment Create(Equipment equipment)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Equipments.Add(equipment);
            ctx.SaveChanges();
            return equipment;
        }

        public bool Delete(int id)
        {
            using var ctx = new NinjaManagerContext();
            var toRemove = ctx.Equipments.Find(id);

            if (toRemove == null) return false;

            ctx.Equipments.Remove(toRemove);
            ctx.SaveChanges();

            return true;
        }

        public List<Equipment> GetAll()
        {
            using var ctx = new NinjaManagerContext();
            return ctx.Equipments.ToList();
        }

        public Equipment GetOne(int id)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.Equipments.FirstOrDefault(m => m.Id == id);
        }

        public Equipment Update(Equipment equipment)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Attach(equipment);
            ctx.Equipments.Update(equipment);
            ctx.SaveChanges();
            return equipment;
        }
    }
}
