namespace Panel.UI
{
    partial class TesfForm
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
            components = new System.ComponentModel.Container();
            colorDialog1 = new ColorDialog();
            button1 = new Button();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2hScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(324, 169);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2hScrollBar1
            // 
            guna2hScrollBar1.InUpdate = false;
            guna2hScrollBar1.LargeChange = 10;
            guna2hScrollBar1.Location = new Point(75, 324);
            guna2hScrollBar1.Name = "guna2hScrollBar1";
            guna2hScrollBar1.ScrollbarSize = 22;
            guna2hScrollBar1.Size = new Size(375, 22);
            guna2hScrollBar1.TabIndex = 1;
            // 
            // TesfForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2hScrollBar1);
            Controls.Add(button1);
            Name = "TesfForm";
            Text = "TesfForm";
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2hScrollBar1;
    }
}