using System.Collections.Generic;
using System.Linq;

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

        public Ninja Update(Ninja ninja)
        {
            using var ctx = new NinjaManagerContext();
            ctx.Attach(ninja);
            ctx.Ninjas.Update(ninja);
            ctx.SaveChanges();
            return ninja;
        }
    }
}
