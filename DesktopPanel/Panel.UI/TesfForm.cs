using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel.UI
{
    public partial class TesfForm : Form
    {
        public TesfForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Renk seçiciyi oluştur
            ColorDialog colorDialog = new ColorDialog();

            // Kullanıcıdan renk seçmesini iste
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen rengi al
                Color selectedColor = colorDialog.Color;

                // Seçilen rengi kullan
                // Örneğin, arka plan rengini değiştir
                this.BackColor = selectedColor;
            }
        }
    }
}
