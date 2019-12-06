using Controlador;
using Controlador.DataSets;
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
            Roles,
            Clients,
            Products,
            Documents,
            Quotations
        }

        public ConsultaRapida(Contexto contexto)
        {
            this.Contexto = contexto;
        }

        public int Consultar(TipoConsulta tipo)
        {
            Controlador.DataSets.ConsultaRapida.TresCamposDTDataTable dataTable = null;
            Controlador.DataSets.ConsultaRapida.CuatroCamposDTDataTable dataTableFechas = null;
            string titulo;
            int columnas = 0;
            switch (tipo)
            {
                case TipoConsulta.Users:
                    dataTable = ConsultarUsuarios();
                    titulo = "Consulta de Usuarios";
                    columnas = 3;
                    break;
                case TipoConsulta.Roles:
                    dataTable = ConsultarRoles();
                    titulo = "Consulta de Roles";
                    columnas = 3;
                    break;
                case TipoConsulta.Clients:
                    dataTable = ConsultarClientes();
                    titulo = "Consulta de Clientes";
                    columnas = 3;
                    break;
                case TipoConsulta.Products:
                    dataTable = ConsultarProductos();
                    titulo = "Consulta de Productos";
                    columnas = 3;
                    break;
                case TipoConsulta.Documents:
                    dataTableFechas = ConsultarDocumentos();
                    titulo = "Consulta de Documentos";
                    columnas = 4;
                    break;
                case TipoConsulta.Quotations:
                    dataTableFechas = ConsultarCotizaciones();
                    titulo = "Consulta de Cotizaciones";
                    columnas = 4;
                    break;
                default:
                    throw new Exception("El tipo de consulta rapida no está definido.");
            }
            if (columnas == 3)
            {
                Formularios.FrmConBordes form = new Formularios.FrmConBordes(new Formularios.FrmConsultaRapidaTresCampos(titulo, dataTable));
                form.ShowDialog();
                return ((Formularios.FrmConsultaRapidaTresCampos)form.Form).Seleccion;
            }
            else if (columnas == 4)
            {
                Formularios.FrmConBordes form = new Formularios.FrmConBordes(new Formularios.FrmConsultaRapidaFechas(titulo, dataTableFechas));
                form.ShowDialog();
                return ((Formularios.FrmConsultaRapidaFechas)form.Form).Seleccion;
            }
            else
            {
                throw new Exception("El tipo de consulta rapida no está definido.");
            }
        }

        private Controlador.DataSets.ConsultaRapida.CuatroCamposDTDataTable ConsultarCotizaciones()
        {
            Quotation quotation = new Quotation(this.Contexto);
            return quotation.ConsultaRapida();
        }

        private Controlador.DataSets.ConsultaRapida.CuatroCamposDTDataTable ConsultarDocumentos()
        {
            Document documents = new Document(this.Contexto);
            return documents.ConsultaRapida();
        }

        private Controlador.DataSets.ConsultaRapida.TresCamposDTDataTable ConsultarClientes()
        {
            Client clients = new Client(this.Contexto);
            return clients.ConsultaRapida();
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

        private Controlador.DataSets.ConsultaRapida.TresCamposDTDataTable ConsultarProductos()
        {
            Product products = new Product(this.Contexto);
            return products.ConsultaRapida();
        }

    }
}
