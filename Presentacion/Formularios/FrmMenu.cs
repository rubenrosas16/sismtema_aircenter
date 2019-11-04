using Proyecto.Formularios;
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

namespace Presentacion.Formularios
{
    public partial class FrmMenu : Form
    {

        #region Constantes y variables    

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        #endregion

        #region Constructores
        public FrmMenu()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos    
      
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CargarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            formulario.Size = this.pnlContenido.Size;
            formulario.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }

        #endregion

        #region Eventos
  
        private void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.Image = Proyecto.Properties.Resources.cerrar;
        }

        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            pbCerrar.Image = Proyecto.Properties.Resources.cerrar2;

        }

        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            pbMinimizar.Image = Proyecto.Properties.Resources.minimizar2 ;
        }

        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar.Image = Proyecto.Properties.Resources.minimizar;

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Para ahcer pruebas, cargamos el formulario base
            //TODO: Quitar esta linea y agregae el resto de forms
            CargarFormulario(new FrmBase());
        }

        private void pnelSuperior_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pbMaxMinTam_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pbMaxMinTam_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pbMaxMinTam.Image = Proyecto.Properties.Resources.maximizar2;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                pbMaxMinTam.Image = Proyecto.Properties.Resources.minTam2;
            }
        }

        private void pbMaxMinTam_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pbMaxMinTam.Image = Proyecto.Properties.Resources.maximizar;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                pbMaxMinTam.Image = Proyecto.Properties.Resources.minTam;
            }
        }

        private void FrmMenu_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pbMaxMinTam.Image = Proyecto.Properties.Resources.maximizar;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                pbMaxMinTam.Image = Proyecto.Properties.Resources.minTam;
            }
        }

        #endregion

    }
}
