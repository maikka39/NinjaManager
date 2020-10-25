using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class NinjaEquipmentRepository : INinjaEquipmentRepository
    {
        public NinjaEquipment Create(NinjaEquipment ninjaEquipment)
        {
            using var ctx = new NinjaManagerContext();
            ctx.NinjaEquipments.Add(ninjaEquipment);
            ctx.SaveChanges();
            return ninjaEquipment;
        }

        public bool Delete(int ninjaId, int equipmentId)
        {
            using var ctx = new NinjaManagerContext();
            var toRemove = ctx.NinjaEquipments.First(o => o.EquipmentId == equipmentId && o.NinjaId == ninjaId);

            if (toRemove == null) return false;

            ctx.NinjaEquipments.Remove(toRemove);
            ctx.SaveChanges();

            return true;
        }

        public List<NinjaEquipment> GetAll()
        {
            using var ctx = new NinjaManagerContext();
            return ctx.NinjaEquipments.ToList();
        }

        public List<Equipment> GetEquipmentFromNinja(Ninja ninja)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.NinjaEquipments.ToList().FindAll(model => model.Ninja == ninja).Select(o => o.Equipment)
                .ToList();
        }

        public List<Ninja> GetNinjaFromEquipment(Equipment equipment)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.NinjaEquipments.ToList().FindAll(model => model.Equipment == equipment).Select(o => o.Ninja)
                .ToList();
        }
    }
}
