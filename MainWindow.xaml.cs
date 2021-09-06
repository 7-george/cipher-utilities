using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Cipher_Utilities
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            //Buttons
            minimizeButton.MouseLeftButtonDown += (s, e) => WindowState = WindowState.Minimized;
            maximizeButton.MouseLeftButtonDown += (s, e) => WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
            closeButton.MouseLeftButtonDown += (s, e) => Close();
            
            //Border
            dragBorder.MouseLeftButtonDown += (s, e) => WindowState = WindowState.Normal;
            dragBorder.PreviewMouseLeftButtonDown += (s, e) => DragMove();
        }

        //DragBorder
        private void dragBorder_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
            var gradient = dragBorder.Background as RadialGradientBrush;
            if (gradient == null)
                return;
            Point pt = Mouse.GetPosition(dragBorder);
            gradient.GradientOrigin = new Point(pt.X / dragBorder.ActualWidth, pt.Y / dragBorder.ActualHeight);
            gradient.Center = gradient.GradientOrigin;

        }

        private void dragBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        //NavPanel
        private void NavPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.SizeAll;
            var gradient = NavPanel.Background as RadialGradientBrush;
            if (gradient == null)
                return;
            Point pt = Mouse.GetPosition(NavPanel);
            gradient.GradientOrigin = new Point(pt.X / NavPanel.ActualWidth, pt.Y / NavPanel.ActualHeight);
            gradient.Center = gradient.GradientOrigin;
        }

        private void NavPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        
        //Background
        private void MainBackground_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
