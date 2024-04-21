namespace Panel.UI
{
    partial class DeleteCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCategoryForm));
            btnDeleteCategory = new Guna.UI2.WinForms.Guna2GradientButton();
            cbxCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            lblCategoryName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.CustomizableEdges = customizableEdges1;
            btnDeleteCategory.DisabledState.BorderColor = Color.DarkGray;
            btnDeleteCategory.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDeleteCategory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDeleteCategory.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnDeleteCategory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDeleteCategory.FillColor = Color.Red;
            btnDeleteCategory.FillColor2 = Color.White;
            btnDeleteCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteCategory.ForeColor = Color.White;
            btnDeleteCategory.Location = new Point(85, 76);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDeleteCategory.Size = new Size(175, 56);
            btnDeleteCategory.TabIndex = 9;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // cbxCategories
            // 
            cbxCategories.BackColor = Color.Transparent;
            cbxCategories.CustomizableEdges = customizableEdges3;
            cbxCategories.DrawMode = DrawMode.OwnerDrawFixed;
            cbxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategories.FocusedColor = Color.FromArgb(94, 148, 255);
            cbxCategories.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbxCategories.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbxCategories.ForeColor = Color.FromArgb(68, 88, 112);
            cbxCategories.ItemHeight = 30;
            cbxCategories.Location = new Point(85, 18);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbxCategories.Size = new Size(175, 36);
            cbxCategories.TabIndex = 6;
            cbxCategories.SelectedIndexChanged += cbxCategories_SelectedIndexChanged;
            // 
            // lblCategoryName
            // 
            lblCategoryName.BackColor = Color.Transparent;
            lblCategoryName.Location = new Point(9, 32);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(70, 22);
            lblCategoryName.TabIndex = 5;
            lblCategoryName.Text = "Category :";
            // 
            // DeleteCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 185);
            Controls.Add(btnDeleteCategory);
            Controls.Add(cbxCategories);
            Controls.Add(lblCategoryName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori sil";
            Load += DeleteCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnDeleteCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategories;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoryName;
    }
}