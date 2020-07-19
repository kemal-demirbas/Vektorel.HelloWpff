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
using System.Windows.Shapes;

namespace Vektorel.HelloWpff
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        Window4 w4;
        public Window5()
        {
            InitializeComponent();
        }
        public Window5(Window4 w4)
        {
            InitializeComponent();
            this.w4 = w4;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            w4.Title = txtbaslik.Text;
        }
    }
}
