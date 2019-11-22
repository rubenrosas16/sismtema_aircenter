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
            User retorno = this.Contexto.Users.Where(x => x.user1 == user && x.password == password && x.status == true).Select(x => x).FirstOrDefault();
            if (retorno != null)
                retorno.Contexto = this.Contexto;
            return retorno;
        }

        public Role GetRol(int idRol)
        {            
            return (from r in Contexto.Roles
                    where r.idRole == idRol
                    select r).FirstOrDefault();
        }

        public bool GetPermisosRol(int idRol, DataSets.RolesDS.PermiosRolDTDataTable dt)
        {
            ReiniciarConexto();
            Role rol = (from r in Contexto.Roles
                       where r.idRole == idRol
                        select r).FirstOrDefault();
            if (rol == null)
                return false;

            List<int> idsPermisos = new List<int>();
            foreach (Permission permiso in rol.Permissions.Where(x => x.status == true))
            {
                dt.AddPermiosRolDTRow(permiso.idPermission, idRol, permiso.name, true);
                idsPermisos.Add(permiso.idPermission);
            }
            var permisos = from p in Contexto.Permissions where p.status == true select p;
            foreach (Permission permiso in permisos)
            {
                if (!idsPermisos.Contains(permiso.idPermission))
                {
                    dt.AddPermiosRolDTRow(permiso.idPermission, idRol, permiso.name, false);
                }
            }
            return true;
        }

        public void GetEstructuraPermisosRol(DataSets.RolesDS.PermiosRolDTDataTable dt)
        {
            ReiniciarConexto();
            var permisos = from p in Contexto.Permissions where p.status == true select p;
            foreach (Permission permiso in permisos)
            {
                dt.AddPermiosRolDTRow(permiso.idPermission, 0, permiso.name, false);
            }
        }

        public void CrearRol(string name, bool activo, DataSets.RolesDS.PermiosRolDTDataTable dt)
        {
            Role role = new Role();
            role.name = name;
            role.status = activo;

            var permisos = (from p in Contexto.Permissions where p.status == true select p).ToList();


            foreach (DataSets.RolesDS.PermiosRolDTRow row in dt)
            {
                if (row.permitir)
                {
                    Permission permiso = new Permission();
                    foreach (Permission perm in permisos)
                    {
                        if (row.idPermiso == perm.idPermission)
                        {
                            permiso = perm;
                            break;
                        }
                    }
                    if (permiso != null)
                        role.Permissions.Add(permiso);
                }
            }

            Contexto.Roles.Add(role);
            Contexto.SaveChanges();
        }

        public void ActualizarRol(int idRol, string nombre, bool activo, DataSets.RolesDS.PermiosRolDTDataTable dt)
        {
            var rol = (from r in Contexto.Roles where  r.idRole == idRol select r).FirstOrDefault();

            if (rol != null)
            {
                rol.name = nombre;
                rol.status = activo;
                List<Permission> permisosPermitir = new List<Permission>();
                List<Permission> permisosBorrar = new List<Permission>();
                foreach (Permission permiso in rol.Permissions)
                {               
                    foreach (DataSets.RolesDS.PermiosRolDTRow row in dt)
                    {
                        if (row.idPermiso == permiso.idPermission)
                        {
                            permisosBorrar.Add(permiso);
                            break;
                        }
                    }
                }

                foreach (Permission permiso in permisosBorrar)
                {
                    rol.Permissions.Remove(permiso);
                }

                var permisos = (from p in Contexto.Permissions where p.status == true select p).ToList();

                foreach (DataSets.RolesDS.PermiosRolDTRow row in dt)
                {
                    if (row.permitir)
                    {
                        Permission permiso = new Permission();
                        foreach (Permission perm in permisos)
                        {
                            if (row.idPermiso == perm.idPermission)
                            {
                                permiso = perm;
                                break;
                            }
                        }
                        if (permiso != null)
                            rol.Permissions.Add(permiso);
                    }
                }
            }
            Contexto.SaveChanges();
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
            if (rol == null || !rol.status)
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

        public List<Role> GetRoles()
        {
            ReiniciarConexto();
            return this.Contexto.Roles.Where(x => x.status).Select(x => x).ToList();
        }

    }
}
