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
    public partial class ApplicationForm : Form
    {
        private IAppService _appService;
        private ICategoryService _categoryService;
        public ApplicationForm()
        {
            InitializeComponent();
            _appService = new AppManager(new EfAppDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }
        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            LoadPanelCategories();
        }

        private void LoadPanelApps(int id = 1)
        {
            List<App> apps = new List<App>();
            apps = _appService.GetAll(i => i.CategoryId == id);
            int verticalPos = 40;
            foreach (App app in apps)
            {
                Button button = new Button();
                button.Size = new Size(100, 30); // Butonun boyutunu ayarla (opsiyonel)
                button.Location = new Point(verticalPos, 10); // Butonun konumunu ayarla (opsiyonel)
                button.Text = app.Name;
                button.Click += (sender, e) =>
                {
                    if (app.FileExtension == ".txt")
                    {
                        System.Diagnostics.Process.Start("notepad.exe", app.Path);
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(app.Path);
                    }

                };
                panelApps.Controls.Add(button);
                verticalPos += button.Width;
            }


        }

        private void LoadPanelCategories()
        {
            List<Category> categories = new List<Category>();
            categories = _categoryService.GetAll();
            foreach (Category category in categories)
            {
                Button button = new Button();
                button.Size = new Size(150, 50);
                button.Location = new Point(10 + category.Id * 200, 10);
                button.Text = category.CategoryName;
                button.Click += (sender, e) =>
                {
                    panelApps.Controls.Clear();
                    LoadPanelApps(category.Id);
                };
                panelCategories.Controls.Add(button);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddAppForm addAppForm = new AddAppForm();
            addAppForm.Show();
        }

        private void btnAppDelete_Click(object sender, EventArgs e)
        {
            RemoveAppForm removeAppForm = new RemoveAppForm();
            removeAppForm.Show();
        }
    }
}
