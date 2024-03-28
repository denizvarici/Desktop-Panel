using Panel.Business.Abstract;
using Panel.Business.Concrete;
using Panel.DataAccess.Concrete.EntityFramework;
using Panel.Entities.Concrete;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using Windows.Foundation.Collections;
namespace Panel.UI
{
    public partial class MainForm : Form
    {
        //private NotifyIcon _notifyIcon; sað aþaðýda küçük icon yapmak icin arastýr

        public MainForm()
        {
            InitializeComponent();
        }



        private void btnApps_Click(object sender, EventArgs e)
        {
            ApplicationForm applicationForm = new ApplicationForm();
            applicationForm.Show();
        }

        private void btnSystemSettings_Click(object sender, EventArgs e)
        {
            SystemSettingsForm systemSettingsForm = new SystemSettingsForm();
            systemSettingsForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPanelSettings_Click(object sender, EventArgs e)
        {
            PanelSettingsForm panelSettingsForm = new PanelSettingsForm();
            panelSettingsForm.Show();
        }



        

        
    }
}
