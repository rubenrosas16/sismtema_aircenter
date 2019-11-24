using Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class ConsultaRapida
    {

        private Contexto Contexto;

        public enum TipoConsulta
        {
            Users,
            Roles
        }

        public ConsultaRapida(Contexto contexto)
        {
            this.Contexto = contexto;
        }

        public int Consultar(TipoConsulta tipo)
        {
            Controlador.DataSets.ConsultaRapida.TresCamposDTDataTable dataTable;
            string titulo;
            switch (tipo)
            {
                case TipoConsulta.Users:
                    dataTable = ConsultarUsuarios();
                    titulo = "Consulta de Usuarios";
                    break;
                case TipoConsulta.Roles:
                    dataTable = ConsultarRoles();
                    titulo = "Consulta de Roles";
                    break;
                default:
                    throw new Exception("El tipo de conutla rapida no está definido.");
            }
            Formularios.FrmConBordes form = new Formularios.FrmConBordes(new Formularios.FrmConsultaRapidaTresCampos(titulo, dataTable));
            form.ShowDialog();
            return ((Formularios.FrmConsultaRapidaTresCampos)form.Form).Seleccion;
        }

        private Controlador.DataSets.ConsultaRapida.TresCamposDTDataTable ConsultarUsuarios()
        {
            User users = new User(this.Contexto);
            return users.ConsultaRapida();
        }

        private Controlador.DataSets.ConsultaRapida.TresCamposDTDataTable ConsultarRoles()
        {
            User users = new User(this.Contexto);
            return users.ConsultaRapidaRoles();
        }

    }
}
