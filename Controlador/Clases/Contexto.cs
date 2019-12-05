using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Contexto : SistemaAirCenterEntities
    {
        public Contexto(string conectionString)
        {
            this.Database.Connection.ConnectionString = conectionString;
        }

    }
}
