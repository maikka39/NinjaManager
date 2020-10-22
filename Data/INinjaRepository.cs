using System.Collections.Generic;

namespace Data
{
    public interface INinjaRepository
    {
        List<Ninja> GetAll();
        Ninja GetOne(int id);
        bool Delete(int id);
        Ninja Update(Ninja ninja);
        Ninja Create(Ninja ninja);
    }
}
