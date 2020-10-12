using ActasAPI.Models;
using System.Collections.Generic;

namespace ActasAPI.Data
{
    public interface ICompromisoAPIRepository
    {
        bool SaveChanges();

        IEnumerable<Compromiso> Get();
        Acta Get(int id);
        void Create(Compromiso item);
        void Update(Compromiso item);
        void Delete(Compromiso item);
    }
}