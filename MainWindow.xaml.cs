using System;
using System.Collections.Generic;
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

namespace Base64
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EncodeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(txt1.Text);
                txt2.Text = Convert.ToBase64String(bytes);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DecodeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var bytes = Convert.FromBase64String(txt1.Text);
                txt2.Text = System.Text.Encoding.UTF8.GetString(bytes);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pasteBtn_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "";
            txt1.Text = Clipboard.GetText();
        }

        private void copyBtn_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txt2.Text);
            txt2.Text = "";
        }
    }
}