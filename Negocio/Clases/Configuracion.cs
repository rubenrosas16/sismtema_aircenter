using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Controlador
{
    public class Configuracion
    {

        private static string nombreXML = "Configuracion.xml";
        private string rutaXML;
        public ConfiguracionLocal Local { get; set; }
        public User User { get; set; }

        public Configuracion()
        {
            rutaXML = GetExecutingDirectory() + @"\" + nombreXML;

            CargarConfiguracionLocal();
        }

        public static string GetExecutingDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }

        public void CargarConfiguracionLocal()
        {
            XmlSerializer ser = new XmlSerializer(typeof(ConfiguracionLocal));
            using (XmlReader reader = XmlReader.Create(rutaXML))
            {
                Local = (ConfiguracionLocal)ser.Deserialize(reader);
            }
        }

        public void GuardarConfiguracionLocal()
        {
            using (var writer = new System.IO.StreamWriter(rutaXML))
            {
                var serializer = new XmlSerializer(typeof (ConfiguracionLocal));
                serializer.Serialize(writer, Local);
                writer.Flush();
            }
        }

    }
}
