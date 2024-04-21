namespace Panel.UI
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            btnCategorySave = new Guna.UI2.WinForms.Guna2Button();
            tbxCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            lblCategoryName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // btnCategorySave
            // 
            btnCategorySave.CustomizableEdges = customizableEdges1;
            btnCategorySave.DisabledState.BorderColor = Color.DarkGray;
            btnCategorySave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCategorySave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCategorySave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCategorySave.FillColor = Color.FromArgb(0, 192, 0);
            btnCategorySave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategorySave.ForeColor = Color.White;
            btnCategorySave.Location = new Point(139, 61);
            btnCategorySave.Name = "btnCategorySave";
            btnCategorySave.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCategorySave.Size = new Size(250, 56);
            btnCategorySave.TabIndex = 13;
            btnCategorySave.Text = "Save";
            btnCategorySave.Click += btnCategorySave_Click;
            // 
            // tbxCategoryName
            // 
            tbxCategoryName.CustomizableEdges = customizableEdges3;
            tbxCategoryName.DefaultText = "";
            tbxCategoryName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbxCategoryName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbxCategoryName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbxCategoryName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbxCategoryName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxCategoryName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbxCategoryName.ForeColor = Color.Black;
            tbxCategoryName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbxCategoryName.Location = new Point(139, 22);
            tbxCategoryName.Name = "tbxCategoryName";
            tbxCategoryName.PasswordChar = '\0';
            tbxCategoryName.PlaceholderText = "";
            tbxCategoryName.SelectedText = "";
            tbxCategoryName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbxCategoryName.Size = new Size(250, 22);
            tbxCategoryName.TabIndex = 9;
            // 
            // lblCategoryName
            // 
            lblCategoryName.BackColor = Color.Transparent;
            lblCategoryName.Location = new Point(19, 22);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(114, 22);
            lblCategoryName.TabIndex = 8;
            lblCategoryName.Text = "Category Name :";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 129);
            Controls.Add(btnCategorySave);
            Controls.Add(tbxCategoryName);
            Controls.Add(lblCategoryName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCategorySave;
        private Guna.UI2.WinForms.Guna2TextBox tbxCategoryName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoryName;
    }
}