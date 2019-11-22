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
    public partial class FrmMessageBox : FrmBaseSinBordes
    {

        public string Texto {
            get
            {
                return lblTexto.Text;
            }
            set
            {
                lblTexto.Text = value;
            }
        }

        public bool BotonCancelar {
            get {
                return btnCancelar.Visible;
            }
            set {
                btnCancelar.Visible = value;
            }
        }

        public FrmMessageBox()
        {
            InitializeComponent();
            BotonCancelar = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (BotonCancelar)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
            ((Form)this.Parent.Parent).Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            ((Form)this.Parent.Parent).Close();
        }

        private void FrmMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (BotonCancelar)
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
                ((Form)this.Parent.Parent).Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.No;
                ((Form)this.Parent.Parent).Close();
            }
        }
    }
}
