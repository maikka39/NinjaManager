using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var equipment = ctx.Equipments.Find(id);

            if (equipment == null) return false;

            var ninjas = GetNinjaFromEquipments(equipment);
            
            var repo = new NinjaRepository();

            foreach (var ninja in ninjas.ToList())
            {
                ninja.Gold += equipment.Cost;

                var newEquipments = repo.GetEquipmentsFromNinja(ninja).Select(e => e.Id).ToList();
                newEquipments.Remove(equipment.Id);

                repo.UpdateEquipments(ninja, newEquipments);

                repo.Update(ninja);
            }

            ctx.Equipments.Remove(equipment);
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
        
        public IEnumerable<Ninja> GetNinjaFromEquipments(Equipment equipment)
        {
            using var ctx = new NinjaManagerContext();

            equipment = ctx.Equipments.Include(e => e.Ninjas).ThenInclude(ne => ne.Ninja).FirstOrDefault(e => e == equipment);

            return equipment == null ? new List<Ninja>() : equipment.Ninjas.Select(i => i.Ninja);
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
