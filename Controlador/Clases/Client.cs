using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public partial class Client : Entidad
    {

        public Client(Contexto contexto) : base(contexto)
        {

        }

        public bool CrearCliente(string name, bool status) 
        {
            Client client = new Client()
            {
                name = name,
                status = status
            };
            this.Contexto.Clients.Add(client);
            this.Contexto.SaveChanges();
            return true;
        }

        public void GuardarCliente(int id, string name, bool status)
        {
            Client client = Contexto.Clients.Where(x => x.idClient == id).Select(x => x).FirstOrDefault();
            if (client != null)
            {
                client.name = name;
                client.status = status;
                Contexto.SaveChanges();
            }
        }

        public Client GetClient(int id)
        {
            ReiniciarConexto();
            Client client = Contexto.Clients.Where(x => x.idClient == id).Select(x => x).FirstOrDefault();
            if (client != null)
                client.Contexto = this.Contexto;
            return client;
        }

        public DataSets.ConsultaRapida.TresCamposDTDataTable ConsultaRapida(bool soloActivos = false)
        {
            ReiniciarConexto();
            DataSets.ConsultaRapida.TresCamposDTDataTable dt = new DataSets.ConsultaRapida.TresCamposDTDataTable();
            var consulta = this.Contexto.Clients.
                Where(x => soloActivos == true ? x.status == true : true).
                Select(x => x).ToArray();
            foreach (Client fila in consulta)
            {
                dt.AddTresCamposDTRow(
                    fila.idClient,
                    fila.name,
                    fila.status
                );
            }
            return dt;
        }

    }
}
