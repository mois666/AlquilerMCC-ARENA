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
    public class UsuarioController
    {
        ModelMCCArena _context = new ModelMCCArena();
        public List<Usuario> GetUsuarios()
        {
            return _context.Usuario.ToList();

        }
        public List<Usuario> Search(string par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetUsuarios();
            }else
            {
                //return _context.Usuario.Where(x => x.Cuenta.Contains(par)||x.Cuenta.Contains(par))
                return _context.Usuario.Where(x => x.Cuenta.Contains(par))
                    .ToList();
            }
        }
        public bool Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            return _context.SaveChanges() > 0;

        }
        public bool Update(Usuario usuario)
        {
            _context.Usuario.Attach(usuario);
            _context.Entry(usuario).State = (System.Data.Entity.EntityState)EntityState.Modified;
            //_context.Entry(usuario).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
        public bool Delete(Usuario usuario)
        {
            _context.Usuario.Remove(usuario);
            return _context.SaveChanges() > 0;
        }
    }
}
