using Microsoft.Toolkit.Uwp.Notifications;
using Panel.Business.Abstract;
using Panel.Business.Concrete;
using Panel.DataAccess.Concrete.EntityFramework;
using Panel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Foundation.Collections;

namespace Panel.UI
{
    public partial class PanelSettingsForm : Form
    {
        private ICommentService _commentService;
        
        
        private static bool isToastListenerAdded = false;

        public PanelSettingsForm()
        {
            InitializeComponent();
            _commentService = new CommentManager(new EfCommentDal());
            if (!isToastListenerAdded)
            {
                ToastNotificationManagerCompat.OnActivated += toastArgs =>
                {
                    ToastArguments args = ToastArguments.Parse(toastArgs.Argument);
                    ValueSet userInput = toastArgs.UserInput;
                    foreach (Form form in Application.OpenForms)
                    {
                        form.Invoke((MethodInvoker)delegate
                        {
                            // Check if the "action" key exists and its value is "visit"
                            if (args.TryGetValue("action", out string action) && action == "visit")
                            {
                                OnVisitButtonClicked();
                            }
                            else if (args.TryGetValue("action", out action) && action == "reply")
                            {
                                OnReplyButtonClicked(userInput);
                            }
                        });
                    }
                };
                isToastListenerAdded = true;
            }
        }

        private bool isReplyButtonClicked = false;
        private void OnReplyButtonClicked(ValueSet userInput)
        {
            if (!isReplyButtonClicked)
            {
                if (userInput.TryGetValue("tbReply", out object replyValue))
                {
                    string replyText = replyValue.ToString();
                    //MessageBox.Show($"Gönderilen Görüş: {replyText}");
                    _commentService.Add(new Comment
                    {
                        Reply = replyText
                    });
                }
                else
                {
                    MessageBox.Show("Görüş alınamadı.");
                }
            }
            isReplyButtonClicked = true;
            
        }

        private bool isVisitButtonClicked = false;
        private void OnVisitButtonClicked()
        {
            if (!isVisitButtonClicked)
            {
                // Visit butonuna tıklanınca yapılacak işlemler
                Process.Start("explorer.exe", "https://denizvarici.com.tr");

                // Bayrağı işaretleyin
                isVisitButtonClicked = true;
            }
        }

        private void PanelSettingsForm_Load(object sender, EventArgs e)
        {
            SendToastMessage();
        }

        

        private void SendToastMessage()
        {
            new ToastContentBuilder()
                .AddText("Deniz Varıcı Masaüstü Paneli")
                .AddText("Uygulamama hoşgeldiniz! ")
                .AddInputTextBox("tbReply", placeHolderContent: "Görüşlerini bildir")
                .AddButton(new ToastButton()
                    .SetContent("Görüş bildir!")
                    .AddArgument("action", "reply")
                    .SetBackgroundActivation())
                .AddButton(new ToastButton()
                    .SetContent("Beğen!")
                    .AddArgument("action", "like")
                    .SetBackgroundActivation())
                .AddButton(new ToastButton()
                    .SetContent("Web sitemi ziyaret et !")
                    .AddArgument("action", "visit")
                    .SetBackgroundActivation())
                .Show();
        }
    }




    //private void SendToastNotification()
    //{
    //    new ToastContentBuilder()
    //    .AddText("Deniz Varıcı Masaüstü Paneli")
    //    .AddText("Uygulamama hoşgeldiniz! ")
    //    // Text box for replying
    //    .AddInputTextBox("tbReply", placeHolderContent: "Görüşlerini bildir")

    //    // Buttons
    //    .AddButton(new ToastButton()
    //        .SetContent("Görüş bildir!")
    //        .AddArgument("action", "reply")
    //        .SetBackgroundActivation())

    //    .AddButton(new ToastButton()
    //        .SetContent("Beğen!")
    //        .AddArgument("action", "like")
    //        .SetBackgroundActivation())
    //    .AddButton(new ToastButton()
    //        .SetContent("Web sitemi ziyaret et !")
    //        .AddArgument("action", "visit")
    //        .SetBackgroundActivation())

    //    // Inline image
    //    //.AddInlineImage(new Uri("https://media.licdn.com/dms/image/D4D03AQF95dTydcvUlQ/profile-displayphoto-shrink_800_800/0/1669101903445?e=1717027200&v=beta&t=PqTYzBVMVYR-Moa4EGpHp_f6xbCYNqG4z-ajdxo4mf0"))

    //    //// Profile (app logo override) image
    //    //.AddAppLogoOverride(new Uri("ms-appdata:///local/Andrew.jpg"), ToastGenericAppLogoCrop.Circle)



    //    .Show();


    //    // Listen to notification activation
    //    ToastNotificationManagerCompat.OnActivated += toastArgs =>
    //    {
    //        // Obtain the arguments from the notification
    //        ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

    //        // Obtain any user input (text boxes, menu selections) from the notification
    //        ValueSet userInput = toastArgs.UserInput;

    //        // Need to dispatch to UI thread if performing UI operations
    //        foreach (Form form in Application.OpenForms)
    //        {
    //            form.Invoke((MethodInvoker)delegate
    //            {
    //                // Check if the "action" key exists and its value is "visit"
    //                if (args.TryGetValue("action", out string action) && action == "visit")
    //                {
    //                    Process.Start("explorer.exe", "https://denizvarici.com.tr");
    //                    this.BackColor = Color.Red;
    //                }
    //            });
    //        }
    //    };
    //}


}
