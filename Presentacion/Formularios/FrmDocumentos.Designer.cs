namespace Presentacion.Formularios
{
    partial class FrmDocumentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEstadoDocumento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnImprimir = new Presentacion.Controles.BotonImagen();
            this.btnCargaDocumento = new Presentacion.Controles.BotonImagen();
            this.btnBuscar = new Presentacion.Controles.BotonImagen();
            this.btnNuevo = new Presentacion.Controles.BotonImagen();
            this.btnGuardar = new Presentacion.Controles.BotonImagen();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbdPDF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdPlantilla = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkActivo.Location = new System.Drawing.Point(145, 47);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(70, 20);
            this.chkActivo.TabIndex = 15;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(48, 100);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(476, 24);
            this.txtDescripcion.TabIndex = 14;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Documento";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(48, 43);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(90, 24);
            this.txtID.TabIndex = 12;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.Validated += new System.EventHandler(this.txtID_Validated);
            // 
            // lblEstadoDocumento
            // 
            this.lblEstadoDocumento.AutoSize = true;
            this.lblEstadoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDocumento.Location = new System.Drawing.Point(45, 284);
            this.lblEstadoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoDocumento.Name = "lblEstadoDocumento";
            this.lblEstadoDocumento.Size = new System.Drawing.Size(158, 16);
            this.lblEstadoDocumento.TabIndex = 20;
            this.lblEstadoDocumento.Text = "Documento en blanco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripcion Documento";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(146, 160);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(378, 24);
            this.txtNombreCliente.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID Cliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.Location = new System.Drawing.Point(48, 160);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(90, 24);
            this.txtIDCliente.TabIndex = 22;
            this.txtIDCliente.TextChanged += new System.EventHandler(this.txtIDCliente_TextChanged);
            this.txtIDCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDCliente_KeyDown);
            this.txtIDCliente.Validated += new System.EventHandler(this.txtIDCliente_Validated);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Pdf |*.pdf";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.ImagenHover = global::Presentacion.Properties.Resources.printer2;
            this.btnImprimir.ImagenNormal = global::Presentacion.Properties.Resources.printer;
            this.btnImprimir.Location = new System.Drawing.Point(199, 390);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(56, 47);
            this.btnImprimir.TabIndex = 25;
            this.btnImprimir.ToolTip = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCargaDocumento
            // 
            this.btnCargaDocumento.ImagenHover = global::Presentacion.Properties.Resources.file2;
            this.btnCargaDocumento.ImagenNormal = global::Presentacion.Properties.Resources.file;
            this.btnCargaDocumento.Location = new System.Drawing.Point(48, 233);
            this.btnCargaDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargaDocumento.Name = "btnCargaDocumento";
            this.btnCargaDocumento.Size = new System.Drawing.Size(56, 47);
            this.btnCargaDocumento.TabIndex = 19;
            this.btnCargaDocumento.ToolTip = "Documento";
            this.btnCargaDocumento.Click += new System.EventHandler(this.btnCargaDocumento_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.ImagenHover = global::Presentacion.Properties.Resources.loupe2;
            this.btnBuscar.ImagenNormal = global::Presentacion.Properties.Resources.loupe;
            this.btnBuscar.Location = new System.Drawing.Point(141, 387);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.ToolTip = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.ImagenHover = global::Presentacion.Properties.Resources._068_plus;
            this.btnNuevo.ImagenNormal = global::Presentacion.Properties.Resources._066_plus;
            this.btnNuevo.Location = new System.Drawing.Point(13, 390);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 47);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.ToolTip = "Nuevo Documento";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.ImagenHover = global::Presentacion.Properties.Resources._036_floppy_disk2;
            this.btnGuardar.ImagenNormal = global::Presentacion.Properties.Resources._036_floppy_disk;
            this.btnGuardar.Location = new System.Drawing.Point(77, 390);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 47);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.ToolTip = "Guardar Documento";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(336, 43);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(188, 24);
            this.txtFecha.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha";
            // 
            // rbdPDF
            // 
            this.rbdPDF.AutoSize = true;
            this.rbdPDF.Checked = true;
            this.rbdPDF.Location = new System.Drawing.Point(15, 29);
            this.rbdPDF.Name = "rbdPDF";
            this.rbdPDF.Size = new System.Drawing.Size(56, 20);
            this.rbdPDF.TabIndex = 28;
            this.rbdPDF.TabStop = true;
            this.rbdPDF.Text = "PDF";
            this.rbdPDF.UseVisualStyleBackColor = true;
            this.rbdPDF.CheckedChanged += new System.EventHandler(this.rbdPDF_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdPlantilla);
            this.groupBox1.Controls.Add(this.rbdPDF);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(336, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 96);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbdPlantilla
            // 
            this.rbdPlantilla.AutoSize = true;
            this.rbdPlantilla.Location = new System.Drawing.Point(15, 60);
            this.rbdPlantilla.Name = "rbdPlantilla";
            this.rbdPlantilla.Size = new System.Drawing.Size(82, 20);
            this.rbdPlantilla.TabIndex = 29;
            this.rbdPlantilla.Text = "Plantilla";
            this.rbdPlantilla.UseVisualStyleBackColor = true;
            this.rbdPlantilla.CheckedChanged += new System.EventHandler(this.rbdPlantilla_CheckedChanged);
            // 
            // FrmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEstadoDocumento);
            this.Controls.Add(this.btnCargaDocumento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "FrmDocumentos";
            this.Text = "FrmDocumentos";
            this.Load += new System.EventHandler(this.FrmDocumentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private Controles.BotonImagen btnBuscar;
        private Controles.BotonImagen btnNuevo;
        private Controles.BotonImagen btnGuardar;
        private Controles.BotonImagen btnCargaDocumento;
        private System.Windows.Forms.Label lblEstadoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Controles.BotonImagen btnImprimir;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbdPDF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdPlantilla;
    }
}