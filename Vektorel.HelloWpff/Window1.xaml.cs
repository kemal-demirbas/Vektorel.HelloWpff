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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int puan = 0;
        public Window1()
        {
            InitializeComponent();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {


                Button btn = new Button();
                btn.Content = rnd.Next(10, 150);
                btn.Width = 100;
                btn.Height = 50;
                btn.Click += Btn_Click;
                wrp.Children.Add(btn);
            }
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            puan += Convert.ToInt32(btn.Content);
            btn.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"puan:{puan}");
        }
    }
}
