using Controlador;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmUsuarios : FrmBaseSinBordes
    {

        private Configuracion Configuracion { get; set; }
        private User Users;

        public FrmUsuarios(Contexto contexto, Configuracion configuracion)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = configuracion;
            this.Users = new User(contexto);
        }

        #region Métodos

        private void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        #endregion

        #region Eventos

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text.Trim() == "" || txtID.Text == "Nuevo")
            {
                txtID.Text = "Nuevo";
                txtID.Text = "";
            }
            else
            {
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "")
            {

            }
            else if (txtUsuario.Text.Trim() == "")
            {

            }
            else if (txtPassword.Text.Trim() == "")
            {

            }

            if (txtID.Text.Trim() == "" || txtID.Text == "Nuevo")
            {
                
                MessageBox.Show("Usuario creado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                Limpiar();
            }
            else
            {
                int id = 0;
                if (int.TryParse(txtID.Text.Trim(), out id) && id != 0)
                {
                    
                    MessageBox.Show("Usuario actualizado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            Utilerias.SoloEnteros((TextBox) sender);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtNombre, ref e);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl( cboRol, ref e);
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtPassword, ref e);
        }

        private void cboRol_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtUsuario, ref e);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cboRol.DataSource = Users.GetRoles();
            cboRol.DisplayMember = "name";

            txtID.Focus();
            Limpiar();
        }

        #endregion

    }
}
