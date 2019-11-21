using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class Entidad
    {

        public Entidad(Contexto contexto = null)
        {
            this.Contexto = contexto;
        }

        public Contexto Contexto { get; set; }

        public void ReiniciarConexto()
        {
            Contexto = new Contexto(this.Contexto.Database.Connection.ConnectionString);
        }

    }
}
