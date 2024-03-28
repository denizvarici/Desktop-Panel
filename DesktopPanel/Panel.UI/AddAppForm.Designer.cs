namespace Panel.UI
{
    partial class AddAppForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblAppName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tbxAppName = new Guna.UI2.WinForms.Guna2TextBox();
            tbxAppPath = new Guna.UI2.WinForms.Guna2TextBox();
            lblAppPath = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnAppBrowse = new Guna.UI2.WinForms.Guna2Button();
            btnAppSave = new Guna.UI2.WinForms.Guna2Button();
            cbxAppCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            lblAppCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Location = new Point(12, 49);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(82, 22);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "App Name :";
            // 
            // tbxAppName
            // 
            tbxAppName.CustomizableEdges = customizableEdges1;
            tbxAppName.DefaultText = "";
            tbxAppName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxAppName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxAppName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxAppName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxAppName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxAppName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAppName.ForeColor = Color.Black;
            tbxAppName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxAppName.Location = new Point(111, 49);
            tbxAppName.Name = "tbxAppName";
            tbxAppName.PasswordChar = '\0';
            tbxAppName.PlaceholderText = "";
            tbxAppName.SelectedText = "";
            tbxAppName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbxAppName.Size = new Size(250, 22);
            tbxAppName.TabIndex = 1;
            // 
            // tbxAppPath
            // 
            tbxAppPath.CustomizableEdges = customizableEdges3;
            tbxAppPath.DefaultText = "";
            tbxAppPath.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxAppPath.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxAppPath.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxAppPath.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxAppPath.Enabled = false;
            tbxAppPath.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxAppPath.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxAppPath.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxAppPath.Location = new Point(111, 89);
            tbxAppPath.Name = "tbxAppPath";
            tbxAppPath.PasswordChar = '\0';
            tbxAppPath.PlaceholderText = "";
            tbxAppPath.SelectedText = "";
            tbxAppPath.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbxAppPath.Size = new Size(250, 22);
            tbxAppPath.TabIndex = 3;
            // 
            // lblAppPath
            // 
            lblAppPath.BackColor = Color.Transparent;
            lblAppPath.Location = new Point(23, 89);
            lblAppPath.Name = "lblAppPath";
            lblAppPath.Size = new Size(71, 22);
            lblAppPath.TabIndex = 2;
            lblAppPath.Text = "App Path :";
            // 
            // btnAppBrowse
            // 
            btnAppBrowse.CustomizableEdges = customizableEdges5;
            btnAppBrowse.DisabledState.BorderColor = Color.DarkGray;
            btnAppBrowse.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAppBrowse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAppBrowse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAppBrowse.FillColor = Color.Silver;
            btnAppBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppBrowse.ForeColor = Color.White;
            btnAppBrowse.Location = new Point(367, 89);
            btnAppBrowse.Name = "btnAppBrowse";
            btnAppBrowse.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnAppBrowse.Size = new Size(80, 22);
            btnAppBrowse.TabIndex = 4;
            btnAppBrowse.Text = "Browse";
            btnAppBrowse.Click += btnAppBrowse_Click;
            // 
            // btnAppSave
            // 
            btnAppSave.CustomizableEdges = customizableEdges7;
            btnAppSave.DisabledState.BorderColor = Color.DarkGray;
            btnAppSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAppSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAppSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAppSave.FillColor = Color.FromArgb(0, 192, 0);
            btnAppSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppSave.ForeColor = Color.White;
            btnAppSave.Location = new Point(111, 181);
            btnAppSave.Name = "btnAppSave";
            btnAppSave.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAppSave.Size = new Size(250, 56);
            btnAppSave.TabIndex = 5;
            btnAppSave.Text = "Save";
            btnAppSave.Click += btnAppSave_Click;
            // 
            // cbxAppCategory
            // 
            cbxAppCategory.BackColor = Color.Transparent;
            cbxAppCategory.CustomizableEdges = customizableEdges9;
            cbxAppCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbxAppCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAppCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxAppCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxAppCategory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxAppCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbxAppCategory.ItemHeight = 30;
            cbxAppCategory.Location = new Point(111, 128);
            cbxAppCategory.Name = "cbxAppCategory";
            cbxAppCategory.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbxAppCategory.Size = new Size(250, 36);
            cbxAppCategory.TabIndex = 6;
            cbxAppCategory.Click += cbxAppCategory_Click;
            // 
            // lblAppCategory
            // 
            lblAppCategory.BackColor = Color.Transparent;
            lblAppCategory.Location = new Point(-1, 142);
            lblAppCategory.Name = "lblAppCategory";
            lblAppCategory.Size = new Size(102, 22);
            lblAppCategory.TabIndex = 7;
            lblAppCategory.Text = "App Category :";
            // 
            // AddAppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 260);
            Controls.Add(lblAppCategory);
            Controls.Add(cbxAppCategory);
            Controls.Add(btnAppSave);
            Controls.Add(btnAppBrowse);
            Controls.Add(tbxAppPath);
            Controls.Add(lblAppPath);
            Controls.Add(tbxAppName);
            Controls.Add(lblAppName);
            Name = "AddAppForm";
            Text = "AddAppForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppName;
        private Guna.UI2.WinForms.Guna2TextBox tbxAppName;
        private Guna.UI2.WinForms.Guna2TextBox tbxAppPath;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppPath;
        private Guna.UI2.WinForms.Guna2Button btnAppBrowse;
        private Guna.UI2.WinForms.Guna2Button btnAppSave;
        private Guna.UI2.WinForms.Guna2ComboBox cbxAppCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAppCategory;
    }
}