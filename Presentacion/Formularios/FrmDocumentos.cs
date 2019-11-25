﻿using Controlador;
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
    public partial class FrmDocumentos : FrmBaseSinBordes
    {
        private Configuracion Configuracion { get; set; }
        public FrmDocumentos(Contexto contexto, Configuracion configuracion)
        {
            InitializeComponent();
            this.Contexto = contexto;
            this.Configuracion = configuracion;
        }

        private void btnCargaDocumento_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName.Length > 0)
            {
                lblEstadoDocumento.Text = "Documento cargado";
            }
        }
    }
}
