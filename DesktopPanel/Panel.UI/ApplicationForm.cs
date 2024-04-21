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
using Guna.UI2;
using Guna.UI2.WinForms;
using Windows.Services.Maps;
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
            LoadTabControl();
        }

        private void LoadTabControl()
        {
            List<Category> categories = _categoryService.GetAll();
            if (categories.Count <= 0)
                return;

            foreach (Category category in categories)
            {
                TabPage tabPage = new TabPage(category.CategoryName);
                List<App> apps = _appService.GetAll(i => i.CategoryId == category.Id);
                int verticalPos = 40;
                foreach (App app in apps)
                {
                    Guna2Button button = new Guna2Button();
                    button.Size = new Size(100, 100); // Butonun boyutunu ayarla (opsiyonel)
                    button.Location = new Point(verticalPos, 10); // Butonun konumunu ayarla (opsiyonel)
                    button.Text = app.Name;

                    if (app.Path != null)
                    {
                        try
                        {
                            Icon fileIcon = Icon.ExtractAssociatedIcon(app.Path);
                            Bitmap bitmapIcon = fileIcon.ToBitmap();
                            button.BackgroundImage = bitmapIcon;
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.FillColor = Color.Transparent;
                            button.ForeColor = Color.Black;
                            button.Font = new Font(button.Font.FontFamily, 5, FontStyle.Bold); // Yeni boyutu 8 olarak belirledim
                            button.Padding = new Padding(button.Padding.Left, button.Padding.Top + 80, button.Padding.Right, button.Padding.Bottom);
                            button.HoverState.FillColor = Color.FromArgb(100, 0, 0, 255);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(app.Name + app.FileExtension + " uygulamasının dosya yolu değiştirilmiş veya silinmiş.");
                        }

                    }

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
                    tabPage.Controls.Add(button);
                    verticalPos += button.Width + 10;
                }
                tabControl.TabPages.Add(tabPage);
            }
        }
        private void btnAppDelete_Click(object sender, EventArgs e)
        {
            RemoveAppForm removeAppForm = new RemoveAppForm();
            removeAppForm.Show();
        }

        private void btnAddApp_Click_1(object sender, EventArgs e)
        {
            AddAppForm addAppForm = new AddAppForm();
            addAppForm.Show();
        }

        private void btnRefreshTabControl_Click(object sender, EventArgs e)
        {
            tabControl.Controls.Clear();
            LoadTabControl();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            DeleteCategoryForm deleteCategoryForm = new DeleteCategoryForm();
            deleteCategoryForm.Show();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();
            addCategoryForm.Show();
        }
    }

    //private void LoadTabControl()
    //{
    //    List<Category> categories = _categoryService.GetAll();
    //    foreach (Category category in categories)
    //    {
    //        TabPage tabPage = new TabPage(category.CategoryName);
    //        List<App> apps = _appService.GetAll(i => i.CategoryId == category.Id);
    //        int verticalPos = 40;
    //        foreach (App app in apps)
    //        {
    //            Button button = new Button();
    //            button.Size = new Size(100, 30); // Butonun boyutunu ayarla (opsiyonel)
    //            button.Location = new Point(verticalPos, 10); // Butonun konumunu ayarla (opsiyonel)
    //            button.Text = app.Name;
    //            button.Click += (sender, e) =>
    //            {
    //                if (app.FileExtension == ".txt")
    //                {
    //                    System.Diagnostics.Process.Start("notepad.exe", app.Path);
    //                }
    //                else
    //                {
    //                    System.Diagnostics.Process.Start(app.Path);
    //                }

    //            };
    //            tabPage.Controls.Add(button);
    //            verticalPos += button.Width;
    //        }
    //        tabControl.TabPages.Add(tabPage);
    //    }
    //}




}
