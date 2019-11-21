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
    public partial class FrmMenu : Form
    {

        #region Constantes y variables    

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private Controlador.Configuracion Configuracion { get; set; }
        private Contexto Contexto { get; set; }

        #endregion

        #region Constructores
        public FrmMenu()
        {
            InitializeComponent();
            Configuracion = new Controlador.Configuracion();
            Contexto = new Contexto(Configuracion.Local.Conexion);

            FrmConBordes login = new FrmConBordes(new FrmLogin(), Contexto);
            login.ShowDialog();

            if (((FrmLogin)login.Form).User == null)
            {
                Environment.Exit(0);
            }

            SetUser(((FrmLogin)login.Form).User);



            //User usuario = new User(Contexto);
            //var usuarios = usuario.GetUsers();

        }

        #endregion

        #region Métodos
      
        private void SetUser(User user)
        {
            Configuracion.User = user;
            lblusuario.Text = user.name;
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CargarFormulario(Form formulario)
        {
            //Vaciamos el panel
            foreach (Control obj in this.pnlContenido.Controls)
            {
                if (obj.Name != tsInfo.Name)
                {
                    if (obj.GetType().IsSubclassOf(typeof(FrmBaseSinBordes)))
                        ((Form)obj).Close();
                    obj.Dispose();
                }
            }
            //Llenamos el panel
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            formulario.Size = new Size(this.pnlContenido.Size.Width, this.pnlContenido.Size.Height - tsInfo.Size.Height);
            formulario.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }

        #endregion

        #region Eventos

        private void btnRoles_Click(object sender, EventArgs e)
        {
            if (this.Configuracion.User.TienePermiso(User.Permiso.Roles))
                CargarFormulario(new FrmRoles(this.Contexto, this.Configuracion));
            else
                MessageBox.Show("No tiene permiso para accesar a esta función.", "Permisos", MessageBox.Botones.Aceptar);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (this.Configuracion.User.TienePermiso(User.Permiso.Usuarios))
                CargarFormulario(new FrmUsuarios(this.Contexto, this.Configuracion));
            else
                MessageBox.Show("No tiene permiso para accesar a esta función.","Permisos", MessageBox.Botones.Aceptar);
        }

        private void pbCerrar_MouseLeave(object sender, EventArgs e)
        {
            pbCerrar.Image = Presentacion.Properties.Resources.cerrar;
        }

        private void pbCerrar_MouseEnter(object sender, EventArgs e)
        {
            pbCerrar.Image = Presentacion.Properties.Resources.cerrar2;
        }

        private void pbMinimizar_MouseEnter(object sender, EventArgs e)
        {
            pbMinimizar.Image = Presentacion.Properties.Resources.minimizar2 ;
        }

        private void pbMinimizar_MouseLeave(object sender, EventArgs e)
        {
            pbMinimizar.Image = Presentacion.Properties.Resources.minimizar;

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
            CargarFormulario(new FrmBaseSinBordes());
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
                pbMaxMinTam.Image = Presentacion.Properties.Resources.maximizar2;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                pbMaxMinTam.Image = Presentacion.Properties.Resources.minTam2;
            }
        }

        private void pbMaxMinTam_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pbMaxMinTam.Image = Presentacion.Properties.Resources.maximizar;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                pbMaxMinTam.Image = Presentacion.Properties.Resources.minTam;
            }
        }

        private void FrmMenu_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                pbMaxMinTam.Image = Presentacion.Properties.Resources.maximizar;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                pbMaxMinTam.Image = Presentacion.Properties.Resources.minTam;
            }
        }

        #endregion

    }
}
