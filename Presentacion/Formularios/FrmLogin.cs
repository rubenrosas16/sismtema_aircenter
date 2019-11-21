using Controlador;
using Presentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.Formularios
{
    public partial class FrmLogin : FrmBaseSinBordes
    {

        public User User { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el Usuario", "Verifique");
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Escriba la Contraseña", "Verifique");
                return;
            }

            User Users = new User(Contexto);
            User = Users.GetUser(txtUser.Text.Trim(), txtPassword.Text);
            if (User != null)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                ((System.Windows.Forms.Form)this.Parent.Parent).Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos.", "Verifique");
            }

        }

        private void txtUser_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                btnLogin.HacerClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                txtPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
