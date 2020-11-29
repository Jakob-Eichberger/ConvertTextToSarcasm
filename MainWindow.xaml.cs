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

namespace ConverTextToSarcasm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtboxInput.Focus();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                var s = txtboxInput.Text.ToLower();
                string f = "";
                Boolean c = true;
                foreach (char x in s)
                {
                    f += x != ' ' ? c ? x.ToString().ToLower() : x.ToString().ToUpper() : ' ';
                    c = x != ' ' ? !c : c;
                    //if (x != ' ')
                    //{
                    //    if (c)
                    //    {
                    //        f += x.ToString().ToUpper();
                    //        c = false;
                    //    }
                    //    else
                    //    {
                    //        f += x.ToString().ToLower();
                    //        c = true;
                    //    }
                    //}
                    //else
                    //{
                    //    f += " ";
                    //}
                }
                Clipboard.SetText(f);
            }
        }
    }
}
