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
            this.Textbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.SuspendLayout();
            // 
            // Textbox1
            // 
            this.Textbox1.BackColor = System.Drawing.Color.White;
            this.Textbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Textbox1.BackgroundImage")));
            this.Textbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Textbox1.ForeColor = System.Drawing.Color.Silver;
            this.Textbox1.Icon = ((System.Drawing.Image)(resources.GetObject("Textbox1.Icon")));
            this.Textbox1.Location = new System.Drawing.Point(12, 12);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(218, 42);
            this.Textbox1.TabIndex = 0;
            this.Textbox1.text = "Buscar";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 139);
            this.Controls.Add(this.Textbox1);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox Textbox1;
    }
}