//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controlador
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuotationProduct
    {
        public int idQuotation { get; set; }
        public int idProduct { get; set; }
        public decimal price { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Quotation Quotation { get; set; }
    }
}
