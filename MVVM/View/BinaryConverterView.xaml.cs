using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cipher_Utilities.MVVM.View
{
    public partial class BinaryConverterView : UserControl
    {
        public BinaryConverterView()
        {
            InitializeComponent();
        }

        private void FromBinaryConvert_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string input = decimalInteger.Text.ToString();

            try
            {
                string parsedInput = Convert.ToInt32(input, 2).ToString();
                decimalInteger.Text = parsedInput;
            } 
            catch
            {
                decimalInteger.Text = "Invalid Input";
            }
        }

        private void BinaryConvert_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string input = decimalInteger.Text.ToString();
            int parsedInput;
            if (int.TryParse(input, out parsedInput))
            {
                int num = parsedInput;
                string binary = Convert.ToString(num, 2);
                decimalInteger.Text = binary;
            } 
            else
            {
                decimalInteger.Text = "Invalid Input";
            }
        }

        private void FromHexConvert_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string input = decimalInteger.Text.ToString();
            try
            {
                string parsedInput = Convert.ToString(Convert.ToInt32(input, 16), 10);
                decimalInteger.Text = parsedInput;
            }
            catch
            {
                decimalInteger.Text = "Invalid Input";
            }
        }

        private void HexConvert_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string input = decimalInteger.Text.ToString();
            int parsedInput;
            if (int.TryParse(input, out parsedInput))
            {
                int num = parsedInput;
                string binary = Convert.ToString(num, 16);
                decimalInteger.Text = binary;
            }
            else
            {
                decimalInteger.Text = "Invalid Input";
            }
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
