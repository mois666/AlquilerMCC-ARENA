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
    public class ClienteController
    {
        ModelMCCArena _context = new ModelMCCArena();
        public List<Cliente> GetClientes()
        {
            return _context.Cliente.ToList();

        }
        public List<Cliente> Search(string par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetClientes();
            }
            else
            {
                return _context.Cliente.Where(x => x.Nombre.Contains(par) || x.Apellido.Contains(par))
                    .ToList();
            }
        }
        public bool Create(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            return _context.SaveChanges() > 0;

        }
        public bool Update(Cliente cliente)
        {
            _context.Cliente.Attach(cliente);
            _context.Entry(cliente).State = (System.Data.Entity.EntityState)EntityState.Modified;

            return _context.SaveChanges() > 0;
        }
        public bool Delete(Cliente cliente)
        {
            _context.Cliente.Remove(cliente);
            return _context.SaveChanges() > 0;
        }

    }
}
