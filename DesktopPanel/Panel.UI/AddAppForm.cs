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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Panel.UI
{
    public partial class AddAppForm : Form
    {
        private IAppService _appService;
        private ICategoryService _categoryService;
        public AddAppForm()
        {
            InitializeComponent();
            _appService = new AppManager(new EfAppDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            
        }

        private void LoadCategoriesToCombobox()
        {
            List<Category> categoryList = _categoryService.GetAll();
            cbxAppCategory.DataSource = categoryList;
            cbxAppCategory.DisplayMember = "CategoryName";
            cbxAppCategory.ValueMember = "Id";
        }

        private void btnAppBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Dosya Seç";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Tüm Dosyalar (*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string appPath = openFileDialog.FileName;
                string appName = System.IO.Path.GetFileNameWithoutExtension(appPath);
                tbxAppPath.Text = appPath;
                tbxAppName.Text = appName;
            }
        }

        private void btnAppSave_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Name = tbxAppName.Text;
            app.Path = tbxAppPath.Text;
            app.CategoryId = (int)cbxAppCategory.SelectedValue;
            app.FileExtension = Path.GetExtension(tbxAppPath.Text);
            _appService.Add(app);
            MessageBox.Show("uygulama eklendi");
        }

        private void cbxAppCategory_Click(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();
        }
    }
}
