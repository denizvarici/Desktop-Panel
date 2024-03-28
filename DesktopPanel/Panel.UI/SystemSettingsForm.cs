using Panel.UI.SoundControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace Panel.UI
{
    public partial class SystemSettingsForm : Form
    {
        private SoundController _soundController;
        public SystemSettingsForm()
        {
            InitializeComponent();
            _soundController = new SoundController();
        }

        private void SystemSettingsForm_Load(object sender, EventArgs e)
        {
            FormLoadSoundState();
            FormLoadWifiState();
        }

        private void SoundPot_ValueChanged(object? sender, EventArgs e)
        {
            _soundController.SetSoundLevel((float)soundPot.Value);
            lblAudioLevel.Text = "Ses :" + (int)soundPot.Value;
        }

        private void FormLoadSoundState()
        {
            soundPot.Value = _soundController.GetCurrentSoundLevel()*100;
            soundPot.ValueChanged += SoundPot_ValueChanged;
            lblAudioLevel.Text = "Ses :" + (int)soundPot.Value;
        }

        private bool IsWifiEnabled()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && nic.OperationalStatus == OperationalStatus.Up)
                {
                    return true;
                }
            }
            return false;
        }
       

        private void FormLoadWifiState()
        {
            wifiToggleSwitch.Checked = IsWifiEnabled();
            
        }

        private void wifiToggleSwitch_Click(object sender, EventArgs e)
        {
            OpenOrCloseWiFi(wifiToggleSwitch.Checked);
        }
        

        public static void OpenOrCloseWiFi(bool isTrue)
        {
            string komut = isTrue ? "interface set interface Wi-Fi enable" : "interface set interface Wi-Fi disable";

            ProcessStartInfo processInfo = new ProcessStartInfo("netsh", komut)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process.Start(processInfo)?.WaitForExit();
        }

       


    }
}
