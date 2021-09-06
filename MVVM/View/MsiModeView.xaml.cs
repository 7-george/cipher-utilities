using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Security.Permissions;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;


namespace Cipher_Utilities.MVVM.View
{
    public partial class MsiModeView : UserControl
    {
        public MsiModeView()
        {
            InitializeComponent();
        }

        private void MsiMode_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process Launch = new Process();
            Launch.StartInfo.FileName = _filePath + "/Library/Bin/MsiModeUtil_v2.exe";
            Launch.StartInfo.UseShellExecute = true;
            Launch.StartInfo.Verb = "runas";
            Launch.Start();
        }

        private void Rtss_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process Launch = new Process();
            Launch.StartInfo.FileName = _filePath + "/Library/Bin/RTSS.exe";
            Launch.StartInfo.UseShellExecute = true;
            Launch.StartInfo.Verb = "runas";
            Launch.Start();
        }


        private void Autoruns_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process Launch = new Process();
            Launch.StartInfo.FileName = _filePath + "/Library/Bin/Autoruns.exe";
            Launch.StartInfo.UseShellExecute = true;
            Launch.StartInfo.Verb = "runas";
            Launch.Start();
        }

        private void Islc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process Launch = new Process();
            Launch.StartInfo.FileName = _filePath + "/Library/Bin/ISLC.exe";
            Launch.StartInfo.UseShellExecute = true;
            Launch.StartInfo.Verb = "runas";
            Launch.Start();
        }

        private void MsiAfterburner_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process Launch = new Process();
            Launch.StartInfo.FileName = _filePath + "/Library/Bin/Afterburner.exe";
            Launch.StartInfo.UseShellExecute = true;
            Launch.StartInfo.Verb = "runas";
            Launch.Start();
        }

        private void HwInfo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process Launch = new Process();
            Launch.StartInfo.FileName = _filePath + "/Library/Bin/HwInfo.exe";
            Launch.StartInfo.UseShellExecute = true;
            Launch.StartInfo.Verb = "runas";
            Launch.Start();
        }

        private void select_Join(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void select_Leave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
    }
}