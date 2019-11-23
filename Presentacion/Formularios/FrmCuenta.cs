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
    public partial class FrmCuenta : FrmBaseSinBordes
    {
        private Configuracion Configuracion { get; set; }

        public FrmCuenta(Contexto contexto)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = Configuracion.GetConfiguracion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPasswordActual.Text == "")
            {
                MessageBox.Show("Escriba la Contraseña actual.","Cambiar contraseña",MessageBox.Botones.Aceptar);
                txtPasswordActual.Focus();
                return;
            }
            else if(txtPasswordNuevo.Text == "")
            {
                MessageBox.Show("Escriba la Contraseña nueva.", "Cambiar contraseña", MessageBox.Botones.Aceptar);
                txtPasswordNuevo.Focus();
                return;
            }
            if (txtPasswordNuevoDos.Text != txtPasswordNuevo.Text)
            {
                MessageBox.Show("Las Contraseñas no coinciden.", "Cambiar contraseña", MessageBox.Botones.Aceptar);
                txtPasswordNuevoDos.Focus();
                return;
            }
            if (this.Configuracion.User.password != txtPasswordActual.Text)
            {
                MessageBox.Show("La Contraseña Actual no es valida.", "Cambiar contraseña", MessageBox.Botones.Aceptar);
                txtPasswordActual.Focus();
                return;
            }

            this.Configuracion.User.Contexto = this.Contexto;
            this.Configuracion.User.password = txtPasswordNuevo.Text;

            this.Configuracion.User.GuardarUsuario(this.Configuracion.User);

            MessageBox.Show("Contraseña cambiada correctamente.", "Cambiar contraseña", MessageBox.Botones.Aceptar);
            txtPasswordActual.Clear();
            txtPasswordNuevo.Clear();
            txtPasswordNuevoDos.Clear();
            txtPasswordActual.Focus();
        }

        private void txtPasswordActual_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtPasswordNuevo,ref e);
        }

        private void txtPasswordNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            Utilerias.SiguienteControl(txtPasswordNuevoDos,ref e);
        }

        private void txtPasswordNuevoDos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGuardar.HacerClick();
        }

        private void FrmCuenta_Shown(object sender, EventArgs e)
        {
            txtPasswordActual.Focus();
        }
    }
}
