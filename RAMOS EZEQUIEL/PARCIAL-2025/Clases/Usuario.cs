using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2025.Clases
{
    internal class Usuario
    {
        public string usuario;
        public int clave;

        public Usuario setUsuario(string usuario, int clave)
        {
            Usuario user = new Usuario();
            user.usuario = usuario;
            user.clave = clave;
            return user;
        }
    }
}
