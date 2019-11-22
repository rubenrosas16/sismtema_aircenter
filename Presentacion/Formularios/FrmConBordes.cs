using Presentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Presentacion.Formularios
{
    public partial class FrmConBordes : Form
    {

        #region Constantes y variables    

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Contexto Contexto { get; set; }
        public FrmBaseSinBordes Form { get;}
        private bool cancelar;
        public string Titulo {
            get {
                return this.Form.Text;
            }
            set {
                this.Text = value;
                this.lblTitulo.Text = value;
            }
        }

        #endregion

        #region Constructores
        public FrmConBordes(FrmBaseSinBordes form, Contexto contexto = null)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Form = form;
            if (contexto != null)
                this.Form.Contexto = Contexto;
            this.Form.TopLevel = false;
            this.Form.AutoScroll = true;
            this.pnlContenido.Size = this.Form.Size;
            this.Size = new Size(this.pnlContenido.Size.Width + 10 + 10, this.pnlContenido.Size.Height + 40 + 9);
            this.pnlContenido.Controls.Add(this.Form);
            this.lblTitulo.Text = this.Form.Text;
            this.cancelar = false;
        }

        #endregion

        #region Métodos    

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        #region Eventos

        private void FrmConBordes_Shown(object sender, EventArgs e)
        {
            this.Form.Show();
            this.pnlContenido.Focus();
            this.Form.Focus();
        }

        private void FrmConBordes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.cancelar)
                this.DialogResult = this.Form.DialogResult;
        }

        private void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.Image = Presentacion.Properties.Resources.cerrar;
        }

        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            pbCerrar.Image = Presentacion.Properties.Resources.cerrar2;

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.cancelar = true;
            this.Form.Close();
            this.Close();
        }

        private void pnelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

    }
}
