using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public partial class User : Entidad
    {

        public enum Permiso
        {
            Usuarios = 1,
            Roles = 2
        }

        public User(Contexto contexto) : base(contexto)
        {

        }

        public User GetUser(string user, string password)
        {
            ReiniciarConexto();
            User retorno = this.Contexto.Users.Where(x => x.user1 == user && x.password == password).Select(x => x).FirstOrDefault();
            if (retorno != null)
                retorno.Contexto = this.Contexto;
            return retorno;
        }

         

        public bool TienePermiso(Permiso permiso)
        {
            ReiniciarConexto();
            User user = (from u in Contexto.Users
                           where u.idUser == this.idUser
                           select u).FirstOrDefault();
            if (user == null)
                return false;
            var rol = user.Roles.FirstOrDefault();
            if (rol == null)
                return false;

            foreach (Permission permission in rol.Permissions)
            {   
                if (permission.status)
                {
                    if (permission.idPermission == (int)permiso || permission.name == permiso.ToString())
                        return true;
                }
            }
            return false;
        }

        public List<User> GetUsers()
        {
            ReiniciarConexto();
            return this.Contexto.Users.Select( x => x).ToList();
        }

    }
}
