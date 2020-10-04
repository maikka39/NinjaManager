using System.Collections.Generic;

namespace Data {
    public interface INinjaRepository {
        List<Ninja> GetAll ();
        Ninja GetOne (string name);
        bool Delete (string name);
        Ninja Update (Ninja ninja);
        Ninja Create (Ninja ninja);
    }
}