namespace Panel.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            contextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            uygulamaToolStripMenuItem = new ToolStripMenuItem();
            uygulamaEkleToolStripMenuItem = new ToolStripMenuItem();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            btnPanelSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            btnSystemSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            btnApps = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            contextMenuStrip.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { uygulamaToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            contextMenuStrip.RenderStyle.BorderColor = Color.Gainsboro;
            contextMenuStrip.RenderStyle.ColorTable = null;
            contextMenuStrip.RenderStyle.RoundedEdges = true;
            contextMenuStrip.RenderStyle.SelectionArrowColor = Color.White;
            contextMenuStrip.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            contextMenuStrip.RenderStyle.SelectionForeColor = Color.White;
            contextMenuStrip.RenderStyle.SeparatorColor = Color.Gainsboro;
            contextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            contextMenuStrip.Size = new Size(146, 28);
            // 
            // uygulamaToolStripMenuItem
            // 
            uygulamaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uygulamaEkleToolStripMenuItem });
            uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            uygulamaToolStripMenuItem.Size = new Size(145, 24);
            uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // uygulamaEkleToolStripMenuItem
            // 
            uygulamaEkleToolStripMenuItem.Name = "uygulamaEkleToolStripMenuItem";
            uygulamaEkleToolStripMenuItem.Size = new Size(190, 26);
            uygulamaEkleToolStripMenuItem.Text = "Uygulama Ekle";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Navy;
            guna2Panel1.Controls.Add(btnExit);
            guna2Panel1.Controls.Add(btnPanelSettings);
            guna2Panel1.Controls.Add(btnSystemSettings);
            guna2Panel1.Controls.Add(btnApps);
            guna2Panel1.CustomizableEdges = customizableEdges6;
            guna2Panel1.Location = new Point(12, 12);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2Panel1.Size = new Size(1011, 467);
            guna2Panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.FillColor = Color.FromArgb(139, 152, 166);
            btnExit.IconColor = Color.White;
            btnExit.Location = new Point(952, 3);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(56, 36);
            btnExit.TabIndex = 3;
            // 
            // btnPanelSettings
            // 
            btnPanelSettings.BorderColor = Color.DarkCyan;
            btnPanelSettings.BorderThickness = 3;
            btnPanelSettings.DisabledState.BorderColor = Color.DarkGray;
            btnPanelSettings.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPanelSettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPanelSettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPanelSettings.FillColor = Color.DarkSlateGray;
            btnPanelSettings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPanelSettings.ForeColor = Color.Aquamarine;
            btnPanelSettings.Location = new Point(758, 132);
            btnPanelSettings.Name = "btnPanelSettings";
            btnPanelSettings.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnPanelSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnPanelSettings.Size = new Size(185, 185);
            btnPanelSettings.TabIndex = 2;
            btnPanelSettings.Text = "Panel Settings";
            btnPanelSettings.Click += btnPanelSettings_Click;
            // 
            // btnSystemSettings
            // 
            btnSystemSettings.BorderColor = Color.DarkCyan;
            btnSystemSettings.BorderThickness = 3;
            btnSystemSettings.DisabledState.BorderColor = Color.DarkGray;
            btnSystemSettings.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSystemSettings.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSystemSettings.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSystemSettings.FillColor = Color.DarkSlateGray;
            btnSystemSettings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSystemSettings.ForeColor = Color.Aquamarine;
            btnSystemSettings.Location = new Point(411, 132);
            btnSystemSettings.Name = "btnSystemSettings";
            btnSystemSettings.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSystemSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnSystemSettings.Size = new Size(185, 185);
            btnSystemSettings.TabIndex = 1;
            btnSystemSettings.Text = "System Settings";
            btnSystemSettings.Click += btnSystemSettings_Click;
            // 
            // btnApps
            // 
            btnApps.BorderColor = Color.DarkCyan;
            btnApps.BorderThickness = 3;
            btnApps.DisabledState.BorderColor = Color.DarkGray;
            btnApps.DisabledState.CustomBorderColor = Color.DarkGray;
            btnApps.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnApps.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnApps.FillColor = Color.DarkSlateGray;
            btnApps.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnApps.ForeColor = Color.Aquamarine;
            btnApps.Location = new Point(60, 132);
            btnApps.Name = "btnApps";
            btnApps.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnApps.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnApps.Size = new Size(185, 185);
            btnApps.TabIndex = 0;
            btnApps.Text = "Applications";
            btnApps.Click += btnApps_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1035, 491);
            ContextMenuStrip = contextMenuStrip;
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel";
            Load += MainForm_Load;
            contextMenuStrip.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem uygulamaToolStripMenuItem;
        private ToolStripMenuItem uygulamaEkleToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnPanelSettings;
        private Guna.UI2.WinForms.Guna2CircleButton btnSystemSettings;
        private Guna.UI2.WinForms.Guna2CircleButton btnApps;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}
