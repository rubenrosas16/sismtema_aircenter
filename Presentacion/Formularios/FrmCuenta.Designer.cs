namespace Presentacion.Formularios
{
    partial class FrmCuenta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new Presentacion.Controles.BotonImagen();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordNuevoDos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources._005_login;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.ImagenHover = global::Presentacion.Properties.Resources._036_floppy_disk2;
            this.btnGuardar.ImagenNormal = global::Presentacion.Properties.Resources._036_floppy_disk;
            this.btnGuardar.Location = new System.Drawing.Point(100, 472);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 47);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.ToolTip = "Guardar Contraseña";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña Actual";
            // 
            // txtPasswordActual
            // 
            this.txtPasswordActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordActual.Location = new System.Drawing.Point(25, 252);
            this.txtPasswordActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordActual.Name = "txtPasswordActual";
            this.txtPasswordActual.PasswordChar = '•';
            this.txtPasswordActual.Size = new System.Drawing.Size(198, 24);
            this.txtPasswordActual.TabIndex = 12;
            this.txtPasswordActual.UseSystemPasswordChar = true;
            this.txtPasswordActual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordActual_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Contraseña Nueva";
            // 
            // txtPasswordNuevo
            // 
            this.txtPasswordNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNuevo.Location = new System.Drawing.Point(25, 317);
            this.txtPasswordNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordNuevo.Name = "txtPasswordNuevo";
            this.txtPasswordNuevo.PasswordChar = '•';
            this.txtPasswordNuevo.Size = new System.Drawing.Size(198, 24);
            this.txtPasswordNuevo.TabIndex = 14;
            this.txtPasswordNuevo.UseSystemPasswordChar = true;
            this.txtPasswordNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordNuevo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Repite la Contraseña Nueva";
            // 
            // txtPasswordNuevoDos
            // 
            this.txtPasswordNuevoDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNuevoDos.Location = new System.Drawing.Point(25, 383);
            this.txtPasswordNuevoDos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordNuevoDos.Name = "txtPasswordNuevoDos";
            this.txtPasswordNuevoDos.PasswordChar = '•';
            this.txtPasswordNuevoDos.Size = new System.Drawing.Size(198, 24);
            this.txtPasswordNuevoDos.TabIndex = 16;
            this.txtPasswordNuevoDos.UseSystemPasswordChar = true;
            this.txtPasswordNuevoDos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordNuevoDos_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtPasswordNuevoDos);
            this.groupBox1.Controls.Add(this.txtPasswordActual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPasswordNuevo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 526);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Contraseña";
            // 
            // FrmCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 544);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCuenta";
            this.Text = "FrmCuenta";
            this.Shown += new System.EventHandler(this.FrmCuenta_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.BotonImagen btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordNuevoDos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}