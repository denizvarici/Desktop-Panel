using Panel.Business.Abstract;
using Panel.Business.Concrete;
using Panel.DataAccess.Concrete.EntityFramework;
using Panel.Entities.Concrete;
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
    public partial class AddCategoryForm : Form
    {
        private ICategoryService _categoryService;
        public AddCategoryForm()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxCategoryName.Text))
            {
                try
                {
                    _categoryService.Add(new Category
                    {
                        CategoryName = tbxCategoryName.Text
                    });
                    MessageBox.Show("Kategori eklendi! Paneli yenileyiniz");
                }
                catch (Exception)
                {
                    MessageBox.Show("HATA! Kategori eklenemedi");
                }
                
            }
        }
    }
}
