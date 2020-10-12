using ActasAPI.Models;
using System.Collections.Generic;

namespace ActasAPI.Data
{
    public interface IResponsableAPIRepository
    {
        bool SaveChanges();

        IEnumerable<Responsable> Get();
        Acta Get(int id);
        void Create(Responsable item);
        void Update(Responsable item);
        void Delete(Responsable item);
    }
}