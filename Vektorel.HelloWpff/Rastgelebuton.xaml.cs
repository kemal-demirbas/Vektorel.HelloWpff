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
    /// Interaction logic for Rastgelebuton.xaml
    /// </summary>
    public partial class Rastgelebuton : Window
    {
        int toplam = 0;
        public Rastgelebuton()
        {
            InitializeComponent();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 50;
                btn.Background = Brushes.Blue;
                btn.Foreground = Brushes.White;
                btn.Content = rnd.Next(10,100);
                //   btn.Margin = new Thickness(rnd.Next(800), rnd.Next(450), 0, 0);
                btn.Click += Btn_Click;
                wrp.Children.Add(btn); 
            }

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btnn = (Button)sender;
            toplam += (int)btnn.Content;
            btnn.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"sonuc:{toplam}");
        }
    }  
}
