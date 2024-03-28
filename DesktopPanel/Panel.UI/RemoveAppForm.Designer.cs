namespace Panel.UI
{
    partial class RemoveAppForm
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
            lblCategoryName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbxCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            cbxApps = new Guna.UI2.WinForms.Guna2ComboBox();
            lblAppName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDeleteApp = new Guna.UI2.WinForms.Guna2GradientButton();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.BackColor = Color.Transparent;
            lblCategoryName.Location = new Point(20, 26);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(70, 22);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Category :";
            // 
            // cbxCategories
            // 
            cbxCategories.BackColor = Color.Transparent;
            cbxCategories.CustomizableEdges = customizableEdges1;
            cbxCategories.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategories.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxCategories.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxCategories.ForeColor = Color.FromArgb(68, 88, 112);
            cbxCategories.ItemHeight = 30;
            cbxCategories.Location = new Point(96, 12);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbxCategories.Size = new Size(175, 36);
            cbxCategories.TabIndex = 1;
            cbxCategories.SelectedIndexChanged += cbxCategories_SelectedIndexChanged;
            // 
            // cbxApps
            // 
            cbxApps.BackColor = Color.Transparent;
            cbxApps.CustomizableEdges = customizableEdges3;
            cbxApps.DrawMode = DrawMode.OwnerDrawFixed;
            cbxApps.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxApps.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxApps.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxApps.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxApps.ForeColor = Color.FromArgb(68, 88, 112);
            cbxApps.ItemHeight = 30;
            cbxApps.Location = new Point(96, 67);
            cbxApps.Name = "cbxApps";
            cbxApps.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbxApps.Size = new Size(175, 36);
            cbxApps.TabIndex = 3;
            // 
            // lblAppName
            // 
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Location = new Point(52, 81);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(38, 22);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "App :";
            // 
            // btnDeleteApp
            // 
            btnDeleteApp.CustomizableEdges = customizableEdges5;
            btnDeleteApp.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteApp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteApp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteApp.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDeleteApp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteApp.FillColor = Color.Red;
            btnDeleteApp.FillColor2 = Color.White;
            btnDeleteApp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteApp.ForeColor = Color.White;
            btnDeleteApp.Location = new Point(96, 137);
            btnDeleteApp.Name = "btnDeleteApp";
            btnDeleteApp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDeleteApp.Size = new Size(175, 56);
            btnDeleteApp.TabIndex = 4;
            btnDeleteApp.Text = "Delete";
            btnDeleteApp.Click += btnDeleteApp_Click;
            // 
            // RemoveAppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(336, 230);
            Controls.Add(btnDeleteApp);
            Controls.Add(cbxApps);
            Controls.Add(lblAppName);
            Controls.Add(cbxCategories);
            Controls.Add(lblCategoryName);
            Name = "RemoveAppForm";
            Text = "RemoveAppForm";
            Load += RemoveAppForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoryName;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategories;
        private Guna.UI2.WinForms.Guna2ComboBox cbxApps;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppName;
        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteApp;
    }
}