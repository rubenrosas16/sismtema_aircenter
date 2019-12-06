using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    [Serializable()]
    public class ConfiguracionLocal
    {
        public string Conexion { get; set; }
        public string UrlInicio { get; set; }

        public string NombreEmpresa { get; set; }

    }
}
