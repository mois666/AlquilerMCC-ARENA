using mccArena.Context;
using mccArena.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mccArena.Controllers
{
    public class CanchaController
    {
        ModelMCCArena _context = new ModelMCCArena();
        public List<Cancha> GetCanchas()
        {
            return _context.Cancha.ToList();

        }
        public List<Cancha> Search(string par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetCanchas();
            }
            else
            {
                return _context.Cancha.Where(x => x.Nombre.Contains(par) || x.Ubicacion.Contains(par))
                    .ToList();
            }
        }
        public bool Create(Cancha cancha)
        {
            _context.Cancha.Add(cancha);
            return _context.SaveChanges() > 0;

        }
        public bool Update(Cancha cancha)
        {
            _context.Cancha.Attach(cancha);
            _context.Entry(cancha).State = (System.Data.Entity.EntityState)EntityState.Modified;
            
            return _context.SaveChanges() > 0;
        }
        public bool Delete(Cancha cancha)
        {
            _context.Cancha.Remove(cancha);
            return _context.SaveChanges() > 0;
        }
    }
}
