namespace Presentacion.Formularios
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnelSuperior = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.tsInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblusuario = new System.Windows.Forms.ToolStripLabel();
            this.lblFechaHora = new System.Windows.Forms.ToolStripLabel();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.btnCuenta = new Presentacion.Controles.BotonImagen();
            this.btnInicio = new Presentacion.Controles.BotonImagen();
            this.btnRoles = new Presentacion.Controles.BotonImagen();
            this.btnUsuarios = new Presentacion.Controles.BotonImagen();
            this.pbMaxMinTam = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pnelSuperior.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.tsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaxMinTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnelSuperior
            // 
            this.pnelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnelSuperior.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnelSuperior.Controls.Add(this.btnCuenta);
            this.pnelSuperior.Controls.Add(this.btnInicio);
            this.pnelSuperior.Controls.Add(this.btnRoles);
            this.pnelSuperior.Controls.Add(this.btnUsuarios);
            this.pnelSuperior.Controls.Add(this.pbMaxMinTam);
            this.pnelSuperior.Controls.Add(this.pbCerrar);
            this.pnelSuperior.Controls.Add(this.pbMinimizar);
            this.pnelSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnelSuperior.Name = "pnelSuperior";
            this.pnelSuperior.Size = new System.Drawing.Size(1009, 70);
            this.pnelSuperior.TabIndex = 0;
            this.pnelSuperior.DoubleClick += new System.EventHandler(this.pnelSuperior_DoubleClick);
            this.pnelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnelSuperior_MouseMove);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenido.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContenido.Controls.Add(this.tsInfo);
            this.pnlContenido.Location = new System.Drawing.Point(10, 70);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(989, 593);
            this.pnlContenido.TabIndex = 1;
            // 
            // tsInfo
            // 
            this.tsInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblusuario,
            this.lblFechaHora});
            this.tsInfo.Location = new System.Drawing.Point(0, 568);
            this.tsInfo.Name = "tsInfo";
            this.tsInfo.Size = new System.Drawing.Size(989, 25);
            this.tsInfo.TabIndex = 0;
            this.tsInfo.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "Usuario:";
            // 
            // lblusuario
            // 
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(49, 22);
            this.lblusuario.Text = "Usuario";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(65, 22);
            this.lblFechaHora.Text = "fechaHora";
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Interval = 30000;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // btnCuenta
            // 
            this.btnCuenta.ImagenHover = global::Presentacion.Properties.Resources._004_login_1;
            this.btnCuenta.ImagenNormal = global::Presentacion.Properties.Resources._005_login;
            this.btnCuenta.Location = new System.Drawing.Point(72, 12);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(54, 52);
            this.btnCuenta.TabIndex = 6;
            this.btnCuenta.ToolTip = "Mi cuenta";
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.ImagenHover = global::Presentacion.Properties.Resources._048_home;
            this.btnInicio.ImagenNormal = global::Presentacion.Properties.Resources._046_home;
            this.btnInicio.Location = new System.Drawing.Point(12, 12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(54, 52);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.ToolTip = "Inicio";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.ImagenHover = global::Presentacion.Properties.Resources.telemarketer2;
            this.btnRoles.ImagenNormal = global::Presentacion.Properties.Resources.telemarketer;
            this.btnRoles.Location = new System.Drawing.Point(192, 12);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(54, 52);
            this.btnRoles.TabIndex = 4;
            this.btnRoles.ToolTip = "Roles";
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.ImagenHover = global::Presentacion.Properties.Resources.affiliate2;
            this.btnUsuarios.ImagenNormal = global::Presentacion.Properties.Resources.affiliate;
            this.btnUsuarios.Location = new System.Drawing.Point(132, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(54, 52);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.ToolTip = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pbMaxMinTam
            // 
            this.pbMaxMinTam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaxMinTam.Image = global::Presentacion.Properties.Resources.maximizar;
            this.pbMaxMinTam.Location = new System.Drawing.Point(911, 12);
            this.pbMaxMinTam.Name = "pbMaxMinTam";
            this.pbMaxMinTam.Size = new System.Drawing.Size(42, 36);
            this.pbMaxMinTam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaxMinTam.TabIndex = 2;
            this.pbMaxMinTam.TabStop = false;
            this.pbMaxMinTam.Click += new System.EventHandler(this.pbMaxMinTam_Click);
            this.pbMaxMinTam.MouseEnter += new System.EventHandler(this.pbMaxMinTam_MouseEnter);
            this.pbMaxMinTam.MouseLeave += new System.EventHandler(this.pbMaxMinTam_MouseLeave);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(959, 12);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(42, 36);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 1;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            this.pbCerrar.MouseEnter += new System.EventHandler(this.pbCerrar_MouseEnter);
            this.pbCerrar.MouseLeave += new System.EventHandler(this.pbCerrar_MouseLeave);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbMinimizar.Location = new System.Drawing.Point(863, 12);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(42, 36);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 0;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            this.pbMinimizar.MouseEnter += new System.EventHandler(this.pbMinimizar_MouseEnter);
            this.pbMinimizar.MouseLeave += new System.EventHandler(this.pbMinimizar_MouseLeave);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1009, 673);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMenu_SizeChanged);
            this.pnelSuperior.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.tsInfo.ResumeLayout(false);
            this.tsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaxMinTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnelSuperior;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMaxMinTam;
        private Controles.BotonImagen btnUsuarios;
        private System.Windows.Forms.ToolStrip tsInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblusuario;
        private Controles.BotonImagen btnRoles;
        private Controles.BotonImagen btnInicio;
        private System.Windows.Forms.ToolStripLabel lblFechaHora;
        private System.Windows.Forms.Timer tmFechaHora;
        private Controles.BotonImagen btnCuenta;
    }
}