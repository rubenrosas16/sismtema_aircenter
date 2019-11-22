namespace Presentacion.Formularios
{
    partial class FrmRoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDRol = new System.Windows.Forms.TextBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.grdPermisos = new System.Windows.Forms.DataGridView();
            this.idPermisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitirDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RolesDS = new Controlador.DataSets.RolesDS();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new Presentacion.Controles.BotonImagen();
            this.btnGuardar = new Presentacion.Controles.BotonImagen();
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Rol";
            // 
            // txtIDRol
            // 
            this.txtIDRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDRol.Location = new System.Drawing.Point(72, 13);
            this.txtIDRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDRol.Name = "txtIDRol";
            this.txtIDRol.Size = new System.Drawing.Size(91, 24);
            this.txtIDRol.TabIndex = 2;
            this.txtIDRol.TextChanged += new System.EventHandler(this.txtIDRol_TextChanged);
            this.txtIDRol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDRol_KeyDown);
            this.txtIDRol.Validating += new System.ComponentModel.CancelEventHandler(this.txtIDRol_Validating);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(171, 13);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(269, 24);
            this.txtNombreRol.TabIndex = 4;
            // 
            // grdPermisos
            // 
            this.grdPermisos.AllowUserToAddRows = false;
            this.grdPermisos.AllowUserToDeleteRows = false;
            this.grdPermisos.AutoGenerateColumns = false;
            this.grdPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPermisoDataGridViewTextBoxColumn,
            this.idRolDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.permitirDataGridViewCheckBoxColumn});
            this.grdPermisos.DataMember = "PermiosRolDT";
            this.grdPermisos.DataSource = this.RolesDS;
            this.grdPermisos.Location = new System.Drawing.Point(44, 83);
            this.grdPermisos.Name = "grdPermisos";
            this.grdPermisos.Size = new System.Drawing.Size(459, 203);
            this.grdPermisos.TabIndex = 0;
            // 
            // idPermisoDataGridViewTextBoxColumn
            // 
            this.idPermisoDataGridViewTextBoxColumn.DataPropertyName = "idPermiso";
            this.idPermisoDataGridViewTextBoxColumn.HeaderText = "idPermiso";
            this.idPermisoDataGridViewTextBoxColumn.Name = "idPermisoDataGridViewTextBoxColumn";
            this.idPermisoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPermisoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idPermisoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idRolDataGridViewTextBoxColumn
            // 
            this.idRolDataGridViewTextBoxColumn.DataPropertyName = "idRol";
            this.idRolDataGridViewTextBoxColumn.HeaderText = "idRol";
            this.idRolDataGridViewTextBoxColumn.Name = "idRolDataGridViewTextBoxColumn";
            this.idRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRolDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idRolDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Permiso";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 365;
            // 
            // permitirDataGridViewCheckBoxColumn
            // 
            this.permitirDataGridViewCheckBoxColumn.DataPropertyName = "permitir";
            this.permitirDataGridViewCheckBoxColumn.HeaderText = "Permitir";
            this.permitirDataGridViewCheckBoxColumn.Name = "permitirDataGridViewCheckBoxColumn";
            this.permitirDataGridViewCheckBoxColumn.Width = 50;
            // 
            // RolesDS
            // 
            this.RolesDS.DataSetName = "RolesDS";
            this.RolesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(447, 18);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.ImagenHover = global::Presentacion.Properties.Resources._068_plus;
            this.btnNuevo.ImagenNormal = global::Presentacion.Properties.Resources._066_plus;
            this.btnNuevo.Location = new System.Drawing.Point(12, 338);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 47);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.ToolTip = "Nuevo Rol";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.ImagenHover = global::Presentacion.Properties.Resources._036_floppy_disk2;
            this.btnGuardar.ImagenNormal = global::Presentacion.Properties.Resources._036_floppy_disk;
            this.btnGuardar.Location = new System.Drawing.Point(74, 338);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 47);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.ToolTip = "Guardar Rol";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 388);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDRol);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdPermisos);
            this.Name = "FrmRoles";
            this.Text = "FrmRoles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPermisos;
        private Controles.BotonImagen btnGuardar;
        private Controlador.DataSets.RolesDS RolesDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPermisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permitirDataGridViewCheckBoxColumn;
        private Controles.BotonImagen btnNuevo;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}