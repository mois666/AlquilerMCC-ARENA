using mccArena.Context;
using mccArena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mccArena.Controllers
{
    public class UsuarioController
    {
        ModelCancha _context = new ModelCancha();
        public List<Usuario> GetUsuarios()
        {
            return _context.Usuario.ToList();

        }
        public List<Usuario> Buscar(string par)
        {
            if (String.IsNullOrEmpty(par))
            {
                return GetUsuarios();
            }else
            {
                return GetUsuarios();//_context.Usuario.Where(u => u.Par == par).ToList();)
            }
        }
    }
}
