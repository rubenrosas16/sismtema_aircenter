using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.DataSets;
using System.Diagnostics;
using System.IO;

namespace Presentacion.Formularios
{
    public partial class FrmCotizacion : FrmBaseSinBordes
    {
        private Configuracion Configuracion { get; set; }
        private Quotation Quotations;
        private Client Client;
        public FrmCotizacion(Contexto contexto, Configuracion configuracion)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = configuracion;
            this.Quotations = new Quotation(contexto);
        }

        private void Limpiar()
        {
            txtID.Text = "";
            txtFecha.Text = DateTime.Now.ToString();
            chkActivo.Checked = true;
            chkVendida.Checked = false;
            txtNombre.Text = "";
            cotizacionesDS.ProductosDT.Rows.Clear();
            cotizacionesDS.DocumentosDT.Rows.Clear();
            gridProductos.ReadOnly = false;
            Client = null;
            txtNombreCliente.Text = "";
            CalcularTotal();
            btnAgregarProducto.Visible = true;
            btnAgregarDocumento.Visible = true;
            txtID.Focus();
        }

        private void btnAgregarDocumento_Click(object sender, EventArgs e)
        {
            ConsultaRapida consultaRapida = new ConsultaRapida(Contexto);
            int id = consultaRapida.Consultar(ConsultaRapida.TipoConsulta.Documents);
            if (id > 0)
            {
                //Agregar el Documento
                Document documents = new Document(Contexto);
                Document document = documents.GetDocument(id);
                foreach (CotizacionesDS.DocumentosDTRow row in cotizacionesDS.DocumentosDT)
                {
                    if (row.id == id)
                    {
                        MessageBox.Show("El documento ya está agregdo.","Documento", MessageBox.Botones.Aceptar);
                        return;
                    }
                }
                cotizacionesDS.DocumentosDT.AddDocumentosDTRow(id, document.description, document.dataFile);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ConsultaRapida consultaRapida = new ConsultaRapida(Contexto);
            int id = consultaRapida.Consultar(ConsultaRapida.TipoConsulta.Products);
            if (id > 0)
            {
                //Agregar el producto
                Product products = new Product(Contexto);
                Product product = products.GetProducto(id);

                cotizacionesDS.ProductosDT.AddProductosDTRow(id, cotizacionesDS.ProductosDT.Rows.Count + 1, product.name, 1, product.price);
                CalcularTotal();
            }
        }

        private void  BorrarFilaProductos(int i)
        {
            if (i >= 0 && i <= cotizacionesDS.ProductosDT.Rows.Count - 1)
                cotizacionesDS.ProductosDT.Rows.RemoveAt(i);
        }

        private void BorrarFilaDocumentos(int i)
        {
            if (i >= 0 && i <= cotizacionesDS.DocumentosDT.Rows.Count - 1)
                cotizacionesDS.DocumentosDT.Rows.RemoveAt(i);
        }

        private void gridProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gridProductos.SelectedRows.Count > 0)
                {
                    BorrarFilaProductos(gridProductos.SelectedRows[0].Index);
                }
            }
        }

        private void gridDocumentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gridDocumentos.SelectedRows.Count > 0)
                {
                    BorrarFilaDocumentos(gridDocumentos.SelectedRows[0].Index);
                }
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach(CotizacionesDS.ProductosDTRow row in cotizacionesDS.ProductosDT)
            {
                total += row.precio * row.cantidad;
            }
            txtTotal.Text = total.ToString("#######0.00");
        }

        private void FrmCotizacion_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilerias.EsTeclaNumerica((TextBox)sender, ref e);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtNombre, ref e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Escriba la descripción.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if (cotizacionesDS.ProductosDT.Rows.Count == 0)
            {
                MessageBox.Show("Debe capturar al menos un producto", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if (Client == null)
            {
                MessageBox.Show("Capture el cliente", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if ((txtID.Text.Trim() == "" || txtID.Text == "Nueva"))
            {
                Quotation quotation = new Quotation();
                quotation.name = txtNombre.Text.Trim();
                quotation.idClient = Client.idClient;
                quotation.sold = chkVendida.Checked;
                quotation.active = chkActivo.Checked;
                quotation.total = decimal.Parse(txtTotal.Text);

                foreach (CotizacionesDS.ProductosDTRow row in cotizacionesDS.ProductosDT)
                {
                    QuotationProduct quotationProduct = new QuotationProduct();
                    quotationProduct.price = row.precio;
                    quotationProduct.idProduct = row.idProducto;
                    quotationProduct.row = row.renglon;
                    quotationProduct.quantity = row.cantidad;
                    quotation.QuotationsProducts.Add(quotationProduct);
                }

                foreach (CotizacionesDS.DocumentosDTRow row in cotizacionesDS.DocumentosDT)
                {
                    Quotations.AgregarDocumento(ref quotation, row);
                }

                Quotations.CrearCotizacion(quotation);

                MessageBox.Show("Cotización creada correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                Limpiar();
            }
            else
            {
                int id = 0;
                if (int.TryParse(txtID.Text.Trim(), out id) && id != 0)
                {
                    Quotation quotation = new Quotation();
                    quotation.id = id;
                    quotation.sold = chkVendida.Checked;
                    quotation.active = chkActivo.Checked;
                    Quotations.ActualizarCotizacion(quotation);
                    MessageBox.Show("Cotización Actualizada correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
            }
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            if (this.txtID.Text.Trim() == "" || this.txtID.Text == "Nueva")
            {
                this.txtID.Text = "Nueva";
                cotizacionesDS.ProductosDT.Rows.Clear();
                cotizacionesDS.DocumentosDT.Rows.Clear();
                chkActivo.Checked = true;
                chkVendida.Checked = false;
                txtFecha.Text = DateTime.Now.ToString();
                txtNombre.Text = "";
                txtTotal.Text = "0.00";
                txtNombreCliente.Text = "";
                txtIDCliente.Text = "";
                Client = null;
                btnAgregarProducto.Visible = true;
                btnAgregarDocumento.Visible = true;
            }
            else
            {
                int id = 0;
                if (!int.TryParse(this.txtID.Text.Trim(), out id))
                {
                    MessageBox.Show("El id no es un valor entero.", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                    return;
                }
                Quotation quotation = Quotations.GetQuotation(id);
                if (quotation == null)
                {
                    MessageBox.Show("La cotización no existe.", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
                else
                {
                    cotizacionesDS.ProductosDT.Rows.Clear();
                    cotizacionesDS.DocumentosDT.Rows.Clear();
                    txtFecha.Text = quotation.date.ToString();
                    chkActivo.Checked = quotation.active;
                    chkVendida.Checked = quotation.sold;
                    txtNombre.Text = quotation.name;
                    txtTotal.Text = quotation.total.ToString();
                    txtIDCliente.Text = quotation.Cliente.idClient.ToString();
                    txtNombreCliente.Text = quotation.Cliente.name;
                    Client = quotation.Cliente;
                    foreach (QuotationProduct quotationProduct in quotation.CotizacionesProductos)
                    {
                        cotizacionesDS.ProductosDT.AddProductosDTRow(quotationProduct.idProduct, quotationProduct.row, quotationProduct.Producto.name, quotationProduct.quantity, quotationProduct.price);
                    }

                    foreach (Document document in quotation.Documentos)
                    {
                        cotizacionesDS.DocumentosDT.AddDocumentosDTRow(document.id, document.description, document.dataFile);
                    }
                    btnAgregarProducto.Visible = false;
                    btnAgregarDocumento.Visible = false;
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            Utilerias.SoloEnteros((TextBox)sender);
        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {
            Utilerias.SoloEnteros((TextBox)sender);
        }

        private void txtIDCliente_Validated(object sender, EventArgs e)
        {
            if (txtIDCliente.Text.Trim().Length == 0)
            {
                txtNombreCliente.Text = "";
                Client = null;
                return;
            }
            int id = 0;
            if (!int.TryParse(this.txtIDCliente.Text.Trim(), out id))
            {
                MessageBox.Show("El id no es un valor entero.", "Documentos", MessageBox.Botones.Aceptar);
                txtNombreCliente.Text = "";
                Client = null;
                return;
            }
            Client clients = new Client(Contexto);
            Client = clients.GetClient(id);
            if (Client == null)
            {
                MessageBox.Show("El cliente no existe.", "Documentos", MessageBox.Botones.Aceptar);
                txtNombreCliente.Text = "";
                return;
            }
            else
            {
                txtNombreCliente.Text = Client.name;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtIDCliente, ref e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaRapida consulta = new ConsultaRapida(Contexto);
            if (txtIDCliente.Focused)
            {
                //Por cliente
                txtIDCliente.Focus();
                int id = consulta.Consultar(ConsultaRapida.TipoConsulta.Clients);
                if (id > 0)
                {
                    txtIDCliente.Text = id.ToString();
                    gridProductos.Focus();
                }
            }
            else
            {
                //Por cotizacion
                txtID.Focus();
                int id = consulta.Consultar(ConsultaRapida.TipoConsulta.Quotations);
                if (id > 0)
                {
                    txtID.Text = id.ToString();
                    txtNombre.Focus();
                }
            }
        }

        private void txtIDCliente_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(gridProductos, ref e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void gridProductos_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotal();
        }

        private void gridProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if((txtID.Text != "" && txtID.Text != "Nueva") || (e.ColumnIndex != cotizacionesDS.ProductosDT.precioColumn.Ordinal && e.ColumnIndex != cotizacionesDS.ProductosDT.cantidadColumn.Ordinal))
                e.Cancel = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtID.Text == "Nueva")
            {
                MessageBox.Show("Para imprimir debe guardar la cotización.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }

            List<QuotationProduct> quotationProducts = new List<QuotationProduct>();

            foreach (CotizacionesDS.ProductosDTRow row in cotizacionesDS.ProductosDT)
            {
                QuotationProduct quotationProduct = new QuotationProduct();
                Product product  = new Product();
                product.name = row.descripcion;
                quotationProduct.quantity = row.cantidad;
                quotationProduct.price = row.precio;
                quotationProduct.Product = product;
                quotationProducts.Add(quotationProduct);
            }


            string rutaPlantilla = AppDomain.CurrentDomain.BaseDirectory + "Plantillas\\Cotizacion.html";
            string rutaHTML = AppDomain.CurrentDomain.BaseDirectory + "Documentos\\plantilla.html";
            string rutaPDF = AppDomain.CurrentDomain.BaseDirectory + "Documentos\\Cotizacion.pdf";

            Directory.CreateDirectory(Path.GetDirectoryName(rutaPlantilla));
            Directory.CreateDirectory(Path.GetDirectoryName(rutaHTML));
            Directory.CreateDirectory(Path.GetDirectoryName(rutaPDF));

            Document.GenerarHTMLDesdePlantilla(rutaPlantilla, rutaHTML, Client, quotationProducts, decimal.Parse(txtTotal.Text));

            Document.GenerarPDFDesdeHTML(rutaHTML, rutaPDF);

            Process.Start(rutaPDF);

            int i = 1;
            foreach (CotizacionesDS.DocumentosDTRow row in cotizacionesDS.DocumentosDT)
            {
                string ruta = AppDomain.CurrentDomain.BaseDirectory + @"Documentos\\Documento" + i + ".pdf";
                Directory.CreateDirectory(Path.GetDirectoryName(ruta));
                File.WriteAllBytes(ruta, row.Document);
                Process.Start(ruta);
                i ++;
            }

        }
    }
}
