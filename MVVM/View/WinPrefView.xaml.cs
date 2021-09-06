using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cipher_Utilities.MVVM.View
{
    public partial class WinPrefView : UserControl
    {
        public WinPrefView()
        {
            InitializeComponent();
        }

        private void select_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void select_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void LightMode_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process regeditProcess = Process.Start(_filePath + "/Library/Scripts/Light Mode.reg", "/S /q");
            regeditProcess.WaitForExit();
        }

        private void DarkMode_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process regeditProcess = Process.Start(_filePath + "/Library/Scripts/Dark Mode.reg", "/S /q");
            regeditProcess.WaitForExit();
        }

        private void EnableTel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process regeditProcess = Process.Start(_filePath + "/Library/Scripts/Enable Telemetry.reg", "/S /q");
            regeditProcess.WaitForExit();
        }

        private void DisableTel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process regeditProcess = Process.Start(_filePath + "/Library/Scripts/Disable Telemetry.reg", "/S /q");
            regeditProcess.WaitForExit();
        }

        private void Transparency_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process regeditProcess = Process.Start(_filePath + "/Library/Scripts/Transparency.reg", "/S /q");
            regeditProcess.WaitForExit();
        }

        private void Opaque_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process regeditProcess = Process.Start(_filePath + "/Library/Scripts/Opaque.reg", "/S /q");
            regeditProcess.WaitForExit();
        }
    }
}
