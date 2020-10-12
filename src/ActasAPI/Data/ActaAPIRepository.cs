using System.Collections.Generic;
using ActasAPI.Models;
using System.Linq;

namespace ActasAPI.Data
{
    public class ActasAPIRepository : IActaAPIRepository
    {
        private readonly ActasDBContext _context;

        public ActasAPIRepository(ActasDBContext context)
        {
            _context = context;
        }
        public void Create(Acta item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Acta item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Acta> Get()
        {
            return _context.Actas.ToList();
        }

        public Acta Get(int id)
        {
            return _context.Actas.FirstOrDefault(p=>p.ActaId==id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Acta item)
        {
            throw new System.NotImplementedException();
        }
    }
}