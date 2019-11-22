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
    public partial class FrmInicio : FrmBaseSinBordes
    {

        Configuracion Configuracion;
        public FrmInicio(Configuracion configuracion)
        {
            InitializeComponent();
            this.Configuracion = configuracion;
            if (Utilerias.HayConexionInternet())
            {
                this.navegador.Navigate(this.Configuracion.Local.UrlInicio);
            }
            else
            {
                this.navegador.Dispose();
            }
        }

    }
}
