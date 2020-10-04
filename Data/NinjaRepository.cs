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

        public bool Delete(string name)
        {
            using var ctx = new NinjaManagerContext();
            var toRemove = ctx.Ninjas.Find(name);

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

        public Ninja GetOne(string name)
        {
            using var ctx = new NinjaManagerContext();
            return ctx.Ninjas.FirstOrDefault(m => m.Name == name);
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