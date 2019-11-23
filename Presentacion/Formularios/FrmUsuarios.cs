using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmUsuarios : FrmBaseSinBordes
    {

        private Configuracion Configuracion { get; set; }
        private User Users;
        private User User;

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
            User = null;
            chkActivo.Enabled = true;
            chkActivo.Checked = true;
            this.txtUsuario.Enabled = true;
            txtID.Focus();
        }

        #endregion

        #region Eventos

        private void txtID_Validated(object sender, EventArgs e)
        {
            if (this.txtID.Text.Trim() == "" || this.txtID.Text == "Nuevo")
            {
                this.txtNombre.Text = "";
                this.txtUsuario.Text = "";
                this.txtPassword.Text = "";
                this.cboRol.SelectedIndex = 0;
                this.txtID.Text = "Nuevo";
                this.User = null;
                chkActivo.Enabled = true;
                txtUsuario.Enabled = true;
            }
            else
            {
                int id = 0;
                if(!int.TryParse(this.txtID.Text.Trim(), out id))
                {
                    MessageBox.Show("El id no es un valor entero.", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                    return;
                }
                this.User = this.Users.GetUser(id);
                if (this.User == null)
                {
                    MessageBox.Show("El Usuario no existe", "Usuarios", MessageBox.Botones.Aceptar);
                    Limpiar();
                    return;
                }
                this.txtNombre.Text = User.name;
                this.txtUsuario.Text = User.user1;
                this.txtUsuario.Enabled = false;
                this.txtPassword.Text = User.password;
                this.chkActivo.Checked = User.status;
                this.cboRol.SelectedItem  = (from Role r in ((List<Role>)cboRol.DataSource) where r.idRole == this.User.Rol.idRole select r).FirstOrDefault();
                if (this.User.idUser == this.Configuracion.User.idUser)
                    chkActivo.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el Nombre.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            else if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el Usuario.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Escriba la Contraseña.", "Verifique", MessageBox.Botones.Aceptar);
                return;
            }

            if ((txtID.Text.Trim() == "" || txtID.Text == "Nuevo") && User == null)
            {
                User = new User()
                {
                    name = this.txtNombre.Text.Trim(),
                    user1 = this.txtUsuario.Text.Trim(),
                    password = this.txtPassword.Text,
                    status = chkActivo.Checked
                };
                User.Rol = (Role)cboRol.SelectedItem;
                if (!Users.CrearUsuario(User))
                {
                    MessageBox.Show("El usuario ya existe, capture otro.", "Usuario", MessageBox.Botones.Aceptar);
                    return;
                }
                MessageBox.Show("Usuario Creado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
                Limpiar();
            }
            else
            {
                int id = 0;
                if (int.TryParse(txtID.Text.Trim(), out id) && id != 0 && User != null)
                {
                    this.User.name = this.txtNombre.Text.Trim();
                    this.User.user1 = this.txtUsuario.Text.Trim();
                    this.User.password = this.txtPassword.Text;
                    this.User.status = chkActivo.Checked;
                    User.Rol = (Role)cboRol.SelectedItem;
                    Users.GuardarUsuario(User);
                        MessageBox.Show("Usuario Actualizado correctamente.", "Usuario", MessageBox.Botones.Aceptar);
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
            List<Role> Roles = this.Users.GetRoles();
            cboRol.DataSource = Roles;
            cboRol.DisplayMember = "name";

            txtID.Focus();
            Limpiar();
        }

        #endregion

    }
}
