using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cipher_Utilities.MVVM.View
{
    public partial class DeepCleanView : UserControl
    {

        public DeepCleanView()
        {
            InitializeComponent();
            var path = Environment.ExpandEnvironmentVariables(@"%UserProfile%\Appdata\Local\Temp");
            int a = Directory.GetFiles(@"C:\Windows\Temp").Length;
            int b = Directory.GetFiles(@"C:\Windows\SoftwareDistribution").Length;
            int c = Directory.GetFiles(path).Length;
            int abc = a + b + c;
            string totalSize = abc.ToString();
            regain.Text = totalSize + "MB";
        }

        private void start_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process cleanLaunch = new Process();
            cleanLaunch.StartInfo.FileName = _filePath + "/Library/Scripts/DeepClean.cmd";
            cleanLaunch.StartInfo.UseShellExecute = true;
            cleanLaunch.StartInfo.Verb = "runas";
            cleanLaunch.EnableRaisingEvents = true;
            cleanLaunch.Start();
            cleanLaunch.WaitForExit();
            MessageBox.Show("Make sure to run this after a windows update or when you need to free up space.", "Finished Cleaning Your PC");
            var path = Environment.ExpandEnvironmentVariables(@"%UserProfile%\Appdata\Local\Temp");
            int a = Directory.GetFiles(@"C:\Windows\Temp").Length;
            int b = Directory.GetFiles(@"C:\Windows\SoftwareDistribution").Length;
            int c = Directory.GetFiles(path).Length;
            int abc = a + b + c;
            string totalSize = abc.ToString();
            regain.Text = "0MB";
            info.Text = "all purgeable files were removed";
        }

        private void select_join(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void select_leave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
    }
}
