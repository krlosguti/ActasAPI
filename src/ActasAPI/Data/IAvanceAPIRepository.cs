using ActasAPI.Models;
using System.Collections.Generic;

namespace ActasAPI.Data
{
    public interface IAvanceAPIRepository
    {
        bool SaveChanges();

        IEnumerable<Avance> Get();
        Acta Get(int id);
        void Create(Avance item);
        void Update(Avance item);
        void Delete(Avance item);
    }
}