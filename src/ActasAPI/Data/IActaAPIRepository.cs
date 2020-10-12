using ActasAPI.Models;
using System.Collections.Generic;

namespace ActasAPI.Data
{
    public interface IActaAPIRepository
    {
        bool SaveChanges();

        IEnumerable<Acta> Get();
        Acta Get(int id);
        void Create(Acta item);
        void Update(Acta item);
        void Delete(Acta item);
    }
}