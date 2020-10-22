using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class NinjaEquipmentRepository : INinjaEquipmentRepository
    {
        public NinjaEquipment Create(NinjaEquipment ninjaEquipment)
        {
            using var ctx = new NinjaManagerContext();
            ctx.NinjaEquipment.Add(ninjaEquipment);
            ctx.SaveChanges();
            return ninjaEquipment;
        }

        public bool Delete(int id)
        {
            using var ctx = new NinjaManagerContext();
            var toRemove = ctx.NinjaEquipment.Find(id);

            if (toRemove == null) return false;

            ctx.NinjaEquipment.Remove(toRemove);
            ctx.SaveChanges();

            return true;
        }

        public List<NinjaEquipment> GetAll()
        {
            using var ctx = new NinjaManagerContext();
            return ctx.NinjaEquipment.ToList();
        }

        public List<Equipment> GetEquipmentFromNinja(Ninja ninja)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.NinjaEquipment.ToList().FindAll(model => model.Ninja == ninja).Select(o => o.Equipment).ToList();
        }
        
        public List<Ninja> GetNinjaFromEquipment(Equipment equipment)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.NinjaEquipment.ToList().FindAll(model => model.Equipment == equipment).Select(o => o.Ninja).ToList();
        }

        public NinjaEquipment Update(NinjaEquipment ninjaEquipment)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Attach(ninjaEquipment);
            ctx.NinjaEquipment.Update(ninjaEquipment);
            ctx.SaveChanges();
            return ninjaEquipment;
        }
    }
}