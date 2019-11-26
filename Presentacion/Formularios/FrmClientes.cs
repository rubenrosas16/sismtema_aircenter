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
    public partial class FrmClientes : FrmBaseSinBordes
    {
        private Configuracion Configuracion { get; set; }
        private Client clients;
        public FrmClientes(Contexto contexto, Configuracion configuracion)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = configuracion;
            this.clients = new Client(this.Contexto);
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            chkActivo.Checked = true;
            txtID.Text = "";
            txtID.Focus();
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            if (this.txtID.Text.Trim() == "" || this.txtID.Text == "Nuevo")
            {
                this.txtID.Text = "Nuevo";
                txtNombre.Text = "";
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
                Client client = clients.GetClient(id);
                if (client == null)
                {
                    MessageBox.Show("El Cliente no existe.", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
                else
                {
                    txtNombre.Text = client.name;
                    chkActivo.Checked = client.status;
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtNombre, ref e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el Nombre.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            if ((txtID.Text.Trim() == "" || txtID.Text == "Nuevo"))
            {
                clients.CrearCliente(txtNombre.Text.Trim(), chkActivo.Checked);
                MessageBox.Show("Usuario Creado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                Limpiar();
            }
            else
            {
                int id = 0;
                if (int.TryParse(txtID.Text.Trim(), out id) && id != 0)
                {
                    clients.GuardarCliente(id, txtNombre.Text.Trim(), chkActivo.Checked);
                    MessageBox.Show("Usuario Actualizado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaRapida consulta = new ConsultaRapida(this.Contexto);
            txtID.Focus();
            int id = consulta.Consultar(ConsultaRapida.TipoConsulta.Clients);
            if (id > 0)
            {
                txtID.Text = id.ToString();
                txtNombre.Focus();
            }
        }
    }
}
