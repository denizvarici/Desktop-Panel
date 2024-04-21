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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            btnAddApp = new Guna.UI2.WinForms.Guna2Button();
            btnAppDelete = new Guna.UI2.WinForms.Guna2Button();
            tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            btnRefreshTabControl = new Guna.UI2.WinForms.Guna2CircleButton();
            btnCategoryDelete = new Guna.UI2.WinForms.Guna2Button();
            btnCategoryAdd = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnAddApp
            // 
            btnAddApp.CustomizableEdges = customizableEdges1;
            btnAddApp.DisabledState.BorderColor = Color.DarkGray;
            btnAddApp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddApp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddApp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddApp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddApp.ForeColor = Color.White;
            btnAddApp.Location = new Point(790, 477);
            btnAddApp.Name = "btnAddApp";
            btnAddApp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddApp.Size = new Size(225, 56);
            btnAddApp.TabIndex = 1;
            btnAddApp.Text = "Uygulama ekle";
            btnAddApp.Click += btnAddApp_Click_1;
            // 
            // btnAppDelete
            // 
            btnAppDelete.CustomizableEdges = customizableEdges3;
            btnAppDelete.DisabledState.BorderColor = Color.DarkGray;
            btnAppDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAppDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAppDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAppDelete.FillColor = Color.Red;
            btnAppDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppDelete.ForeColor = Color.White;
            btnAppDelete.Location = new Point(549, 477);
            btnAppDelete.Name = "btnAppDelete";
            btnAppDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAppDelete.Size = new Size(225, 56);
            btnAppDelete.TabIndex = 4;
            btnAppDelete.Text = "Uygulama sil";
            btnAppDelete.Click += btnAppDelete_Click;
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Left;
            tabControl.ItemSize = new Size(180, 40);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(894, 429);
            tabControl.TabButtonHoverState.BorderColor = Color.Empty;
            tabControl.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonHoverState.ForeColor = Color.White;
            tabControl.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            tabControl.TabButtonIdleState.BorderColor = Color.Empty;
            tabControl.TabButtonIdleState.FillColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            tabControl.TabButtonIdleState.InnerColor = Color.FromArgb(33, 42, 57);
            tabControl.TabButtonSelectedState.BorderColor = Color.Empty;
            tabControl.TabButtonSelectedState.FillColor = Color.FromArgb(29, 37, 49);
            tabControl.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl.TabButtonSelectedState.ForeColor = Color.White;
            tabControl.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            tabControl.TabButtonSize = new Size(180, 40);
            tabControl.TabIndex = 5;
            tabControl.TabMenuBackColor = Color.FromArgb(33, 42, 57);
            // 
            // btnRefreshTabControl
            // 
            btnRefreshTabControl.DisabledState.BorderColor = Color.DarkGray;
            btnRefreshTabControl.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefreshTabControl.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefreshTabControl.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefreshTabControl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefreshTabControl.ForeColor = Color.White;
            btnRefreshTabControl.Location = new Point(929, 12);
            btnRefreshTabControl.Name = "btnRefreshTabControl";
            btnRefreshTabControl.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnRefreshTabControl.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnRefreshTabControl.Size = new Size(86, 76);
            btnRefreshTabControl.TabIndex = 6;
            btnRefreshTabControl.Text = "Yenile";
            btnRefreshTabControl.Click += btnRefreshTabControl_Click;
            // 
            // btnCategoryDelete
            // 
            btnCategoryDelete.CustomizableEdges = customizableEdges6;
            btnCategoryDelete.DisabledState.BorderColor = Color.DarkGray;
            btnCategoryDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCategoryDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCategoryDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCategoryDelete.FillColor = Color.Red;
            btnCategoryDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoryDelete.ForeColor = Color.White;
            btnCategoryDelete.Location = new Point(15, 477);
            btnCategoryDelete.Name = "btnCategoryDelete";
            btnCategoryDelete.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnCategoryDelete.Size = new Size(225, 56);
            btnCategoryDelete.TabIndex = 8;
            btnCategoryDelete.Text = "Kategori sil";
            btnCategoryDelete.Click += btnCategoryDelete_Click;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.CustomizableEdges = customizableEdges8;
            btnCategoryAdd.DisabledState.BorderColor = Color.DarkGray;
            btnCategoryAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCategoryAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCategoryAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCategoryAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategoryAdd.ForeColor = Color.White;
            btnCategoryAdd.Location = new Point(256, 477);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.ShadowDecoration.CustomizableEdges = customizableEdges9;
            btnCategoryAdd.Size = new Size(225, 56);
            btnCategoryAdd.TabIndex = 7;
            btnCategoryAdd.Text = "Kategori ekle";
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1027, 545);
            Controls.Add(btnCategoryDelete);
            Controls.Add(btnCategoryAdd);
            Controls.Add(btnRefreshTabControl);
            Controls.Add(tabControl);
            Controls.Add(btnAppDelete);
            Controls.Add(btnAddApp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ApplicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uygulama Paneli";
            Load += ApplicationForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddApp;
        private Guna.UI2.WinForms.Guna2Button btnAppDelete;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private Guna.UI2.WinForms.Guna2CircleButton btnRefreshTabControl;
        private Guna.UI2.WinForms.Guna2Button btnCategoryDelete;
        private Guna.UI2.WinForms.Guna2Button btnCategoryAdd;
    }
}