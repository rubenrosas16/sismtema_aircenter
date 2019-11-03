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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnelSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMaxMinTam = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pnelSuperior.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(10, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 593);
            this.panel2.TabIndex = 1;
            // 
            // pbMaxMinTam
            // 
            this.pbMaxMinTam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaxMinTam.Image = global::Proyecto.Properties.Resources.maximizar;
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
            this.pbMinimizar.Image = global::Proyecto.Properties.Resources.minimizar;
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmMenu_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FrmMenu_SizeChanged);
            this.pnelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMaxMinTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnelSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMaxMinTam;
    }
}