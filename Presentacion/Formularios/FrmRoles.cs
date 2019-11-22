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
    public partial class FrmRoles : FrmBaseSinBordes
    {
        private Configuracion Configuracion { get; set; }
        private User User;

        public FrmRoles(Contexto contexto, Configuracion configuracion)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = configuracion;

            User = new User(contexto);
        }

        private void CargarRol()
        {
            RolesDS.PermiosRolDT.Rows.Clear();

            int id = 0;
            if (!int.TryParse(txtIDRol.Text.Trim(), out id))
            {
                MessageBox.Show("El id no es valido.", "Rol", MessageBox.Botones.Aceptar);
                txtIDRol.Focus();
                return;
            }

            Role role = User.GetRol(id);
            if (role == null)
            {
                MessageBox.Show("El rol no existe.", "Rol", MessageBox.Botones.Aceptar);
                txtIDRol.Focus();
                return;
            }

            if (!User.GetPermisosRol(id, RolesDS.PermiosRolDT))
            {
                MessageBox.Show("El rol no existe.", "Rol", MessageBox.Botones.Aceptar);
                txtIDRol.Focus();
                return;
            }

            txtNombreRol.Text = role.name;
            chkActivo.Checked = role.status;
        }
        private void Limpiar()
        {
            txtIDRol.Text = "";
            txtNombreRol.Text = "";
            RolesDS.PermiosRolDT.Rows.Clear();
            chkActivo.Checked = true;
            txtIDRol.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            grdPermisos.EndEdit();
            if (txtNombreRol.Text.Trim() == "")
            {
                MessageBox.Show("Escribe el nombre del Rol.", "Rol", MessageBox.Botones.Aceptar);
                return;
            }                
            if (txtIDRol.Text.Trim() == "" || txtIDRol.Text == "Nuevo")
            {
                User.CrearRol(txtNombreRol.Text, chkActivo.Checked, RolesDS.PermiosRolDT);
                MessageBox.Show("Rol creado correctamente.", "Rol", MessageBox.Botones.Aceptar);
                Limpiar();
            }
            else
            {
                int id = 0;
                if (int.TryParse(txtIDRol.Text.Trim(), out id) && id != 0)
                {
                    User.ActualizarRol(id, txtNombreRol.Text, chkActivo.Checked, RolesDS.PermiosRolDT);
                    MessageBox.Show("Rol guardado correctamente.", "Rol", MessageBox.Botones.Aceptar);
                    Limpiar();
                }
            }
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtIDRol_Validating(object sender, CancelEventArgs e)
        {
            if (txtIDRol.Text.Trim() == "" || txtIDRol.Text == "Nuevo")
            {
                txtIDRol.Text = "Nuevo";
                txtNombreRol.Text = "";
                RolesDS.PermiosRolDT.Rows.Clear();
                User.GetEstructuraPermisosRol(RolesDS.PermiosRolDT);
            }
            else
            {
                CargarRol();
            }
        }

        private void txtIDRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                txtNombreRol.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtIDRol_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIDRol.Text, "[^0-9]"))
            {
                txtIDRol.Text = txtIDRol.Text.Remove(txtIDRol.Text.Length - 1);
            }
        }
    }
}
