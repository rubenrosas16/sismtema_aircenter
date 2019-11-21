using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion.Formularios;

namespace Presentacion
{
    public static class MessageBox
    {

        public enum Botones
        {
            Aceptar, 
            SiNO
        }

        public static System.Windows.Forms.DialogResult Show(string texto, string titulo, Botones botones = Botones.Aceptar)
        {
            FrmConBordes frmBase = new FrmConBordes(new FrmMessageBox());
            frmBase.Titulo = titulo;
            ((FrmMessageBox) frmBase.Form).Texto = texto;
            ((FrmMessageBox) frmBase.Form).BotonCancelar = botones == Botones.SiNO;

            return frmBase.ShowDialog();
        }

    }
}
