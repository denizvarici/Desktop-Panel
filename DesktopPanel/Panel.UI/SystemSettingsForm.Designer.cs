namespace Panel.UI
{
    partial class SystemSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemSettingsForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            waveformPainter1 = new NAudio.Gui.WaveformPainter();
            soundPot = new NAudio.Gui.Pot();
            lblAudioLevel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            wifiToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // waveformPainter1
            // 
            waveformPainter1.Location = new Point(717, 79);
            waveformPainter1.Name = "waveformPainter1";
            waveformPainter1.Size = new Size(94, 29);
            waveformPainter1.TabIndex = 7;
            waveformPainter1.Text = "waveformPainter1";
            // 
            // soundPot
            // 
            soundPot.Location = new Point(114, 27);
            soundPot.Margin = new Padding(4, 5, 4, 5);
            soundPot.Maximum = 100D;
            soundPot.Minimum = 0D;
            soundPot.Name = "soundPot";
            soundPot.Size = new Size(133, 82);
            soundPot.TabIndex = 10;
            soundPot.Value = 0.5D;
            // 
            // lblAudioLevel
            // 
            lblAudioLevel.BackColor = Color.Transparent;
            lblAudioLevel.Location = new Point(159, 102);
            lblAudioLevel.Name = "lblAudioLevel";
            lblAudioLevel.Size = new Size(32, 22);
            lblAudioLevel.TabIndex = 11;
            lblAudioLevel.Text = "Ses :";
            // 
            // wifiToggleSwitch
            // 
            wifiToggleSwitch.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            wifiToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            wifiToggleSwitch.CheckedState.InnerBorderColor = Color.White;
            wifiToggleSwitch.CheckedState.InnerColor = Color.White;
            wifiToggleSwitch.CustomizableEdges = customizableEdges1;
            wifiToggleSwitch.Location = new Point(45, 102);
            wifiToggleSwitch.Name = "wifiToggleSwitch";
            wifiToggleSwitch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            wifiToggleSwitch.Size = new Size(52, 31);
            wifiToggleSwitch.TabIndex = 12;
            wifiToggleSwitch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            wifiToggleSwitch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            wifiToggleSwitch.UncheckedState.InnerBorderColor = Color.White;
            wifiToggleSwitch.UncheckedState.InnerColor = Color.White;
            wifiToggleSwitch.Click += wifiToggleSwitch_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(33, 27);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox1.Size = new Size(74, 69);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 13;
            guna2PictureBox1.TabStop = false;
            // 
            // SystemSettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 151);
            Controls.Add(guna2PictureBox1);
            Controls.Add(wifiToggleSwitch);
            Controls.Add(lblAudioLevel);
            Controls.Add(soundPot);
            Controls.Add(waveformPainter1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SystemSettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistem ayarları";
            Load += SystemSettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.Pot soundPot;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAudioLevel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch wifiToggleSwitch;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}