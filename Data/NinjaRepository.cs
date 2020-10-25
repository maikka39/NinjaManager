using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class NinjaRepository : INinjaRepository
    {
        public Ninja Create(Ninja ninja)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Ninjas.Add(ninja);
            ctx.SaveChanges();
            return ninja;
        }

        public bool Delete(int id)
        {
            using var ctx = new NinjaManagerContext();
            var toRemove = ctx.Ninjas.Find(id);

            if (toRemove == null) return false;

            ctx.Ninjas.Remove(toRemove);
            ctx.SaveChanges();

            return true;
        }

        public List<Ninja> GetAll()
        {
            using var ctx = new NinjaManagerContext();
            return ctx.Ninjas.ToList();
        }

        public Ninja GetOne(int id)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.Ninjas.FirstOrDefault(n => n.Id == id);
        }

        public IEnumerable<Equipment> GetEquipmentsFromNinja(Ninja ninja)
        {
            using var ctx = new NinjaManagerContext();

            ninja = ctx.Ninjas.Include(n => n.Equipments).ThenInclude(ne => ne.Equipment).FirstOrDefault(n => n == ninja);
            
            return ninja.Equipments.Select(i => i.Equipment);
        }

        public Ninja Update(Ninja ninja)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Attach(ninja);
            ctx.Ninjas.Update(ninja);
            ctx.SaveChanges();
            return ninja;
        }
        
        public Ninja UpdateEquipments(Ninja ninja, List<Equipment> equipments)
        {
            using var ctx = new NinjaManagerContext();

            ctx.Attach(ninja);

            ctx.Entry(ninja).Collection(n => n.Equipments).Load();

            var equipmentsInNinja = ninja.Equipments.Select(i => i.EquipmentId).ToArray();

            foreach (var equipment in ctx.Equipments)
            {
                if (equipments.Contains(equipment))
                {
                    if (!equipmentsInNinja.Contains(equipment.Id))
                    {
                        ninja.Equipments.Add(new NinjaEquipment {NinjaId = ninja.Id, EquipmentId = equipment.Id});
                    }
                }
                else if (equipmentsInNinja.Contains(equipment.Id))
                {
                    ctx.Remove(ninja.Equipments.FirstOrDefault(ne => ne.EquipmentId == equipment.Id)!);
                }
            }

            ctx.Ninjas.Update(ninja);
            ctx.SaveChanges();
            return ninja;
        }
    }
}
