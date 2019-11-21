using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controles
{

    [DefaultEvent("Click")]
    public partial class BotonImagen : UserControl
    {

        public string ToolTip
        {
            get
            {
                return objToolTip.GetToolTip(pbImagen);
            }
            set
            {
                objToolTip.RemoveAll();
                objToolTip.SetToolTip(pbImagen, value);
            }
        }

        public Image ImagenNormal {
            get {
                return imagnenNormal;
            }
            set {
                imagnenNormal = value;
                pbImagen.Image = value;
            }
        }

        private Image imagnenNormal;

        public Image ImagenHover { get; set; }

        public BotonImagen()
        {
            InitializeComponent();
        }

        private void pbImagen_MouseEnter(object sender, EventArgs e)
        {
            pbImagen.Image = ImagenHover;

        }

        private void pbImagen_MouseLeave(object sender, EventArgs e)
        {
            pbImagen.Image = ImagenNormal;
        }

        public new event EventHandler Click;

        private void OnClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            OnClick();
        }

        public void HacerClick()
        {
            OnClick();
        }

    }
}
