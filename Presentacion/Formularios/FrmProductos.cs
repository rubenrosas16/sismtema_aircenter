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

namespace Presentacion.Formularios
{

    public partial class FrmProductos : FrmBaseSinBordes
    {
        private Configuracion Configuracion { get; set; }
        private Product Products;
        public FrmProductos(Contexto contexto, Configuracion configuracion)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = configuracion;
            Products = new Product(this.Contexto);
            Limpiar();
        }

        private void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            chkActivo.Checked = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilerias.EsTeclaNumerica((TextBox) sender, ref e);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            Utilerias.SoloEnteros((TextBox)sender);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaRapida consulta = new ConsultaRapida(this.Contexto);
            txtID.Focus();
            int id = consulta.Consultar(ConsultaRapida.TipoConsulta.Products);
            if (id > 0)
            {
                txtID.Text = id.ToString();
                txtNombre.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el Nombre.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el Precio.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if ((txtID.Text.Trim() == "" || txtID.Text == "Nuevo"))
            {
                Product Product = new Product();
                Product.name = txtNombre.Text.Trim();
                Product.price = decimal.Parse(txtPrecio.Text);
                Product.active = chkActivo.Checked;
                Products.CrearProducto(Product);
                MessageBox.Show("Producto Creado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                Limpiar();
            }
            else
            {
                int id = 0;
                if (int.TryParse(txtID.Text.Trim(), out id) && id != 0)
                {
                    Product Product = new Product();
                    Product.name = txtNombre.Text.Trim();
                    Product.price = decimal.Parse(txtPrecio.Text);
                    Product.active = chkActivo.Checked;
                    Product.id = id;
                    Products.ActualizarProducto(Product);
                    MessageBox.Show("Producto Actualizado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            if (this.txtID.Text.Trim() == "" || this.txtID.Text == "Nuevo")
            {
                this.txtID.Text = "Nuevo";
                txtNombre.Text = "";
                txtPrecio.Text = "";
                chkActivo.Checked = true;
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
                Product product = Products.GetProducto(id);
                if (product == null)
                {
                    MessageBox.Show("El Producto no existe.", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
                else
                {
                    txtNombre.Text = product.name;
                    txtPrecio.Text = product.price.ToString();
                    chkActivo.Checked = product.active;
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtNombre, ref e);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtPrecio, ref e);
        }
    }
}
