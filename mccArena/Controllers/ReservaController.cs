using mccArena.Context;
using mccArena.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mccArena.Controllers
{
    public class ReservaController
    {
        ModelMCCArena _context = new ModelMCCArena();
        public List<Reserva> GetReservas()
        {
            return _context.Reserva.ToList();

        }
        public List<Reserva> Search(string par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetReservas();
            }
            else
            {
                return _context.Reserva.Where(x => x.HoraInicio.Contains(par) || x.HoraFinal.Contains(par))
                    .ToList();
            }
        }
        public bool Create(Reserva reserva)
        {
            _context.Reserva.Add(reserva);
            return _context.SaveChanges() > 0;

        }
        public bool Update(Reserva reserva)
        {
            _context.Reserva.Attach(reserva);
            _context.Entry(reserva).State = (System.Data.Entity.EntityState)EntityState.Modified;

            return _context.SaveChanges() > 0;
        }
        public bool Delete(Reserva reserva)
        {
            _context.Reserva.Remove(reserva);
            return _context.SaveChanges() > 0;
        }
    }
}
