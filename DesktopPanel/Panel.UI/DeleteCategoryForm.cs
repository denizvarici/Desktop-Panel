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
    public partial class DeleteCategoryForm : Form
    {
        private ICategoryService _categoryService;
        private int _selectedCategoryId;
        public DeleteCategoryForm()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();
        }
        private void LoadCategoriesToCombobox()
        {
            List<Category> categoryList = _categoryService.GetAll();
            cbxCategories.DataSource = categoryList;
            cbxCategories.DisplayMember = "CategoryName";
            cbxCategories.ValueMember = "Id";
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Delete(new Category
                {
                    Id = _selectedCategoryId
                });
                MessageBox.Show("Kategori silme başarılı! Sayfayı yenileyiniz!");
            }
            catch (Exception)
            {
                MessageBox.Show("kategori silme hatası oluştu!");
            }

        }

        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox; // Sender'ı ComboBox türüne dönüştür

            if (comboBox != null)
            {
                // ComboBox'ın seçili öğesine erişin
                object selectedValueObject = comboBox.SelectedValue;

                if (selectedValueObject != null && comboBox.Focused)
                {
                    // SelectedValue özelliğini uygun türe dönüştür
                    int selectedValue;
                    if (int.TryParse(selectedValueObject.ToString(), out selectedValue))
                    {
                        // ComboBox'tan seçilen öğenin ValueMember özelliğindeki değere erişin
                        _selectedCategoryId = selectedValue;
                    }
                    else
                    {
                        // Dönüşüm başarısız olduysa, uygun bir işlem yapın
                        MessageBox.Show("başarısız");
                    }
                }
            }
        }
    }
}