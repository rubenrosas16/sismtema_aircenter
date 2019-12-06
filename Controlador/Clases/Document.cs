using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public partial class Document : Entidad
    {

        public Client Cliente {get; set; }

        public Document(Contexto contexto) : base (contexto)
        {

        }

        public bool CrearDocumento(Document document)
        {
            document.date = DateTime.Now;
            this.Contexto.Documents.Add(document);
            this.Contexto.SaveChanges();
            return true;
        }

        public void ActualizarDocumento(Document documentoActualizar)
        {
            Document documentoActual = (
                from p in this.Contexto.Documents
                where p.id == documentoActualizar.id
                select p
            ).FirstOrDefault();

            if (documentoActual != null)
            {
                documentoActual.description = documentoActualizar.description;
                documentoActual.idClient = documentoActualizar.idClient;
                documentoActual.dataFile = documentoActualizar.dataFile;
                documentoActual.active = documentoActualizar.active;
                this.Contexto.SaveChanges();
            }

        }

        public Document GetDocument(int id)
        {
            ReiniciarConexto();
            Document document = Contexto.Documents.Where(x => x.id == id).Select(x => x).FirstOrDefault();
            if (document != null)
            {
                document.Contexto = this.Contexto;
                document.Cliente = document.Client;
            }
            return document;
        }

        public void AbrirDocumento()
        {
            if (this.dataFile.Length > 0)
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + @"Documentos\\Documento.pdf";
                File.WriteAllBytes(ruta, this.dataFile);
                Process.Start(ruta);
            }
        }

        public byte[] ObtenerDocumentoDesdePlantilla(string rutaPlantilla, int idCliente) 
        {
            ReiniciarConexto();

            string rutaHTML = AppDomain.CurrentDomain.BaseDirectory + "Documentos\\plantilla.html";
            string rutaPDF = AppDomain.CurrentDomain.BaseDirectory + "Documentos\\Documento.pdf";

            Client client = Contexto.Clients.Where(x => x.idClient == idCliente).Select(x => x).FirstOrDefault();

            GenerarHTMLDesdePlantilla(rutaPlantilla, rutaHTML, client, null, 0);

            GenerarPDFDesdeHTML(rutaHTML, rutaPDF);

            return File.ReadAllBytes(rutaPDF);
        }

        public static void GenerarHTMLDesdePlantilla(string rutaPlantilla, string rutaHTML, Client client, List<QuotationProduct> products, decimal total)
        {
            string textoPlantilla = File.ReadAllText(rutaPlantilla, Encoding.UTF8);

            if (textoPlantilla.Contains("{{Sucursal}}"))
            {
                textoPlantilla = textoPlantilla.Replace("{{Sucursal}}", "AirCenter SA de SV");
            }

            if (client != null && textoPlantilla.Contains("{{Client}}"))
            {
                //Client client = Contexto.Clients.Where(x => x.idClient == idClient).Select(x => x).FirstOrDefault();
                textoPlantilla = textoPlantilla.Replace("{{Client}}", client.name);
            }

            if(products != null && textoPlantilla.Contains("{{Repetir_Productos}}"))
            {
                string productos = "";
                foreach (QuotationProduct renglon in products)
                {
                    productos += 
                        "<tr>" +
                            "<td>" + renglon.Product.name.Trim() + "</td>" +
                            "<td>" + renglon.quantity.ToString("######0.00") + "</td>" +
                            "<td>" + renglon.price.ToString("$ #######0.00") + "</td>" +
                            "<td>" + (renglon.price * renglon.quantity).ToString("$ #######0.00") + "</td>" +
                        "</tr>";
                }
                textoPlantilla = textoPlantilla.Replace("{{Repetir_Productos}}", productos);
            }

            if (textoPlantilla.Contains("{{Total}}"))
            {
                textoPlantilla = textoPlantilla.Replace("{{Total}}", total.ToString("$ #######0.00"));
            }

            File.WriteAllText(rutaHTML, textoPlantilla, Encoding.UTF8);
        }

        public static void GenerarPDFDesdeHTML(string rutaHTML, string rutaPDF)
        {
            string rutaLib = AppDomain.CurrentDomain.BaseDirectory + "wkhtmltox\\wkhtmltopdf.exe";
            ProcessStartInfo oProcessStartInfo = new ProcessStartInfo();
            oProcessStartInfo.UseShellExecute = false;
            oProcessStartInfo.FileName = rutaLib;
            oProcessStartInfo.Arguments = "\"" + rutaHTML + "\" \"" + rutaPDF + "\"";
            Process oProcess = new Process();
            oProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            oProcessStartInfo.CreateNoWindow = true;
            oProcess.StartInfo = oProcessStartInfo;
            oProcess.Start();
            oProcess.WaitForExit();
            oProcess.Dispose();
        }

        public DataSets.ConsultaRapida.CuatroCamposDTDataTable ConsultaRapida(bool soloActivos = false)
        {
            ReiniciarConexto();
            DataSets.ConsultaRapida.CuatroCamposDTDataTable dt = new DataSets.ConsultaRapida.CuatroCamposDTDataTable();
            var consulta = this.Contexto.Documents.
                Where(x => soloActivos == true ? x.active : true).
                Select(x => x).ToArray();
            foreach (Document fila in consulta)
            {
                dt.AddCuatroCamposDTRow(
                    fila.id,
                    fila.description,
                    fila.date.ToString(),
                    fila.active
                );
            }
            return dt;
        }


    }
}
