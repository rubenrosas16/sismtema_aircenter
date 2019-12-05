using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public partial class Product : Entidad
    {

        public Product() { 
        
        }
        public Product(Contexto contexto) : base(contexto)
        {

        }

        public Product GetProducto(int id)
        {
            Product product = Contexto.Products.Where(x => x.id == id).Select(x => x).FirstOrDefault();
            if (product != null)
                product.Contexto = this.Contexto;
            return product;
        }

        public bool CrearProducto(Product product)
        {
            this.Contexto.Products.Add(product);
            this.Contexto.SaveChanges();
            return true;
        }

        public void ActualizarProducto(Product productoActualizar)
        {
            Product productoActual = (
                from p in this.Contexto.Products
                where p.id == productoActualizar.id
                select p
            ).FirstOrDefault();

            if (productoActual != null)
            {
                productoActual.name = productoActualizar.name;
                productoActual.price = productoActualizar.price;
                productoActual.active = productoActualizar.active;
                this.Contexto.SaveChanges();
            }

        }

        public DataSets.ConsultaRapida.TresCamposDTDataTable ConsultaRapida(bool soloActivos = false)
        {
            ReiniciarConexto();
            DataSets.ConsultaRapida.TresCamposDTDataTable dt = new DataSets.ConsultaRapida.TresCamposDTDataTable();
            var consulta = this.Contexto.Products.
                Where(x => soloActivos == true ? x.active : true).
                Select(x => x).ToArray();
            foreach (Product fila in consulta)
            {
                dt.AddTresCamposDTRow(
                    fila.id,
                    fila.name,
                    fila.active
                );
            }
            return dt;
        }

    }
}
