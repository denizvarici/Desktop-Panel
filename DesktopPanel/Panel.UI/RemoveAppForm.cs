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

    public partial class RemoveAppForm : Form
    {
        private IAppService _appService;
        private ICategoryService _categoryService;
        public RemoveAppForm()
        {
            InitializeComponent();
            _appService = new AppManager(new EfAppDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }


        private void LoadAppsToCombobox(int categoryId)
        {
            List<App> appList = _appService.GetAll(i => i.CategoryId == categoryId);
            cbxApps.DataSource = appList;
            cbxApps.DisplayMember = "Name";
            cbxApps.ValueMember = "Id";
        }
        private void LoadCategoriesToCombobox()
        {
            List<Category> categoryList = _categoryService.GetAll();
            cbxCategories.DataSource = categoryList;
            cbxCategories.DisplayMember = "CategoryName";
            cbxCategories.ValueMember = "Id";
        }

        private void RemoveAppForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();
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
                        LoadAppsToCombobox(selectedValue);
                    }
                    else
                    {
                        // Dönüşüm başarısız olduysa, uygun bir işlem yapın
                        MessageBox.Show("başarısız");
                    }
                }
            }
        }

        private void btnDeleteApp_Click(object sender, EventArgs e)
        {
            try
            {
                _appService.Delete(new App
                {
                    Id = (int)cbxApps.SelectedValue
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işlemi başarısız oldu!");
            }
            
        }
    }


}
