namespace Panel.UI
{
    partial class PanelSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSettingsForm));
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(12, 77);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(776, 22);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Bu kısım daha sonra eklenecektir. Burada panelinizin renklerini kendiniz ayarlıyabileceğiniz bir ayarlayıcı kısmı olacak!";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 345);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(192, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Developed By Deniz VARICI";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(222, 345);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(161, 20);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "www.denizvarici.com.tr";
            // 
            // PanelSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 374);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(guna2HtmlLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PanelSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Ayarları";
            Load += PanelSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}