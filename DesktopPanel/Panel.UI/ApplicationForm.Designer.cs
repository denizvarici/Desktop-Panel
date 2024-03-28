namespace Panel.UI
{
    partial class ApplicationForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelApps = new Guna.UI2.WinForms.Guna2Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panelCategories = new Guna.UI2.WinForms.Guna2Panel();
            btnAppDelete = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panelApps
            // 
            panelApps.CustomizableEdges = customizableEdges1;
            panelApps.Location = new Point(12, 84);
            panelApps.Name = "panelApps";
            panelApps.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelApps.Size = new Size(1004, 377);
            panelApps.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(779, 467);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Uygulama ekle";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panelCategories
            // 
            panelCategories.CustomizableEdges = customizableEdges5;
            panelCategories.Location = new Point(12, 12);
            panelCategories.Name = "panelCategories";
            panelCategories.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelCategories.Size = new Size(1004, 66);
            panelCategories.TabIndex = 3;
            // 
            // btnAppDelete
            // 
            btnAppDelete.CustomizableEdges = customizableEdges7;
            btnAppDelete.DisabledState.BorderColor = Color.DarkGray;
            btnAppDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAppDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAppDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAppDelete.FillColor = Color.Red;
            btnAppDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppDelete.ForeColor = Color.White;
            btnAppDelete.Location = new Point(538, 467);
            btnAppDelete.Name = "btnAppDelete";
            btnAppDelete.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAppDelete.Size = new Size(225, 56);
            btnAppDelete.TabIndex = 4;
            btnAppDelete.Text = "Uygulama sil";
            btnAppDelete.Click += btnAppDelete_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 531);
            Controls.Add(btnAppDelete);
            Controls.Add(panelCategories);
            Controls.Add(guna2Button1);
            Controls.Add(panelApps);
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            Load += ApplicationForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelApps;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel panelCategories;
        private Guna.UI2.WinForms.Guna2Button btnAppDelete;
    }
}