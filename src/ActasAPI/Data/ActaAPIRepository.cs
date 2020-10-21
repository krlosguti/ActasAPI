using System.Collections.Generic;
using ActasAPI.Models;
using System.Linq;
using System;

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
            if (item==null)
            {
                throw new ArgumentNullException(nameof(item));
            }
           _context.Actas.Add(item);
        }
        public void Update(Acta item)
        {
           
        }
        public void Delete(Acta item)
        {
            if (item==null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _context.Actas.Remove(item);
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
            return(_context.SaveChanges()>=0);
        }
    }
}