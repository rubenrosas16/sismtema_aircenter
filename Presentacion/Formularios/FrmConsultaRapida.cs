using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentacion.ConsultaRapida;

namespace Presentacion.Formularios
{
    public partial class FrmConsultaRapidaTresCampos : FrmBaseSinBordes
    {
        private int seleccion;
        public int Seleccion {
            get { 
                return seleccion; 
            } 
        }

        public FrmConsultaRapidaTresCampos(string text, Controlador.DataSets.ConsultaRapida.TresCamposDTDataTable dataTable)
        {
            InitializeComponent();
            this.Text = text;

            foreach (DataRow row in dataTable.Rows)
            {
                consultaRapida.TresCamposDT.ImportRow(row);
            }
            seleccion = 0;
        }

        private void SeleccionarFila(int i)
        {
            seleccion = consultaRapida.TresCamposDT[i].id;
            this.DialogResult = DialogResult.OK;
            ((System.Windows.Forms.Form)this.Parent.Parent).Close();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila(e.RowIndex);
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (grid.SelectedRows.Count > 0)
                {
                    SeleccionarFila(grid.SelectedRows[0].Index);
                }
            }
        }
    }
}
