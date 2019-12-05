using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public partial class User : Entidad
    {

        public Role Rol { get; set; }

        public enum Permiso
        {
            Usuarios = 1,
            Roles = 2,
            Productos = 3,
            Documentos = 4,
            Cotizaciones = 5,
            Clientes = 6
        }

        public User(Contexto contexto) : base(contexto)
        {

        }

        public bool CrearUsuario(User user)
        {
            if ((from u in Contexto.Users where u.user1.Trim().ToUpper() == user.user1.Trim().ToUpper() select u).Any())           
                return false; //Ya existe el usuario


            Role rol = (from r in Contexto.Roles where r.idRole == user.Rol.idRole select r).FirstOrDefault();

            user.Roles.Add(rol);
            this.Contexto.Users.Add(user);
            this.Contexto.SaveChanges();
            return true;
        }

        public void GuardarUsuario(User userActualizado)
        {
            User userActual = (from u in this.Contexto.Users
                           where u.idUser == userActualizado.idUser
                           select u).FirstOrDefault();

            userActual.name = userActualizado.name;
            userActual.password = userActualizado.password;
            userActual.status = userActualizado.status;
            userActual.user1 = userActualizado.user1;

            if (userActualizado.Rol != null)
            {
                //Si tiene rol, lo actualizamos
                Role rolNuevo = (from r in this.Contexto.Roles
                                 where r.idRole == userActualizado.Rol.idRole
                                 select r).FirstOrDefault();

                Role rolActual = userActual.Roles.FirstOrDefault();
                userActual.Roles.Remove(rolActual);
                userActual.Roles.Add(rolNuevo);
            }

            this.Contexto.SaveChanges();
        }

        public User GetUser(string user, string password)
        {
            ReiniciarConexto();
            User retorno = this.Contexto.Users.Where(x => x.user1.Trim().ToUpper() == user.Trim().ToUpper() && x.password == password && x.status == true).Select(x => x).FirstOrDefault();
            if (retorno != null)
                retorno.Contexto = this.Contexto;
            return retorno;
        }

        public User GetUser(int idUser)
        {
            ReiniciarConexto();
            User retorno = this.Contexto.Users.Where(x => x.idUser == idUser).Select(x => x).FirstOrDefault();
            if (retorno != null)
            {
                retorno.Contexto = this.Contexto;
                retorno.Rol = retorno.Roles.FirstOrDefault();
            }
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
        public List<User> GetUsers(bool soloActivos = false)
        {
            ReiniciarConexto();
            return this.Contexto.Users.Where(x => soloActivos == true ? x.status == true : true).Select( x => x).ToList();
        }

        public List<Role> GetRoles()
        {
            ReiniciarConexto();
            return this.Contexto.Roles.Where(x => x.status).Select(x => x).ToList();
        }

        public DataSets.ConsultaRapida.TresCamposDTDataTable ConsultaRapida(bool soloActivos = false)
        {
            ReiniciarConexto();
            DataSets.ConsultaRapida.TresCamposDTDataTable dt = new DataSets.ConsultaRapida.TresCamposDTDataTable();
            var consulta = this.Contexto.Users.
                Where(x => soloActivos == true ? x.status == true : true).
                Select(x => x).ToArray();
            foreach (User fila in consulta)
            {
                dt.AddTresCamposDTRow(
                    fila.idUser,
                    fila.name,
                    fila.status
                );
            }
            return dt;
        }

        public DataSets.ConsultaRapida.TresCamposDTDataTable ConsultaRapidaRoles(bool soloActivos = false)
        {
            ReiniciarConexto();
            DataSets.ConsultaRapida.TresCamposDTDataTable dt = new DataSets.ConsultaRapida.TresCamposDTDataTable();
            var consulta = this.Contexto.Roles.
                Where(x => soloActivos == true ? x.status == true : true).
                Select(x => x).ToArray();
            foreach (Role fila in consulta)
            {
                dt.AddTresCamposDTRow(
                    fila.idRole,
                    fila.name,
                    fila.status
                );
            }
            return dt;
        }

    }
}
