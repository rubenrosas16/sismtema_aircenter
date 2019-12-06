using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.DataSets;

namespace Controlador
{
    public partial class Quotation : Entidad
    {
        public List<QuotationProduct> CotizacionesProductos { get; set; }
        public List<Document> Documentos { get; set; }
        public Client Cliente { get; set; }


        public Quotation(Contexto contexto) : base(contexto)
        {

        }


        public void ObtenerProductoCotizacion()
        {

        }

        public bool CrearCotizacion(Quotation quotation)
        {
            quotation.date = DateTime.Now;
            this.Contexto.Quotations.Add(quotation);
            this.Contexto.SaveChanges();
            return true;
        }

        public void ActualizarCotizacion(Quotation quotationActualizar)
        {
            Quotation quotationActual = (
                from p in this.Contexto.Quotations
                where p.id == quotationActualizar.id
                select p
            ).FirstOrDefault();

            if (quotationActual != null)
            {
                quotationActual.active = quotationActualizar.active;
                quotationActual.sold = quotationActualizar.sold;
                this.Contexto.SaveChanges();
            }

        }

        public Quotation GetQuotation(int id)
        {
            ReiniciarConexto();
            Quotation quotation = Contexto.Quotations.Where(x => x.id == id).Select(x => x).FirstOrDefault();
            if (quotation != null)
            {
                quotation.Contexto = this.Contexto;

                quotation.Cliente = quotation.Client;

                quotation.CotizacionesProductos = new List<QuotationProduct>();
                foreach(QuotationProduct quotationProduct in quotation.QuotationsProducts)
                {
                    quotationProduct.Producto = quotationProduct.Product;
                    quotation.CotizacionesProductos.Add(quotationProduct);
                }
                quotation.Documentos = new List<Document>();
                foreach (Document document in quotation.Documents)
                {
                    quotation.Documentos.Add(document);
                }
            }
            return quotation;
        }

        public ConsultaRapida.CuatroCamposDTDataTable ConsultaRapida(bool soloActivos = false)
        {
            ReiniciarConexto();
            DataSets.ConsultaRapida.CuatroCamposDTDataTable dt = new DataSets.ConsultaRapida.CuatroCamposDTDataTable();
            var consulta = this.Contexto.Quotations.
                Where(x => soloActivos == true ? x.active : true).
                Select(x => x).ToArray();
            foreach (Quotation fila in consulta)
            {
                dt.AddCuatroCamposDTRow(
                    fila.id,
                    fila.name,
                    fila.date.ToString(),
                    fila.active
                );
            }
            return dt;
        }

        public void AgregarDocumento(ref Quotation cot, CotizacionesDS.DocumentosDTRow row)
        {
            Document doc = this.Contexto.Documents.
                Where(x => row.id == x.id).
                Select(x => x).FirstOrDefault();

            cot.Documents.Add(doc);
        }

    }

    public partial class QuotationProduct
    {
        public Product Producto { get; set; }
    }

}
