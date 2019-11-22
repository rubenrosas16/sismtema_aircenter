namespace Presentacion.Formularios
{
    partial class FrmInicio
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.navegador = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navegador
            // 
            this.navegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navegador.Location = new System.Drawing.Point(0, 0);
            this.navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegador.Name = "navegador";
            this.navegador.Size = new System.Drawing.Size(773, 497);
            this.navegador.TabIndex = 1;
            this.navegador.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 93);
            this.label1.TabIndex = 2;
            this.label1.Text = "El Sistema AirCenter No tiene acceso a Internet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 497);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.WebBrowser navegador;
        private System.Windows.Forms.Label label1;
    }
}