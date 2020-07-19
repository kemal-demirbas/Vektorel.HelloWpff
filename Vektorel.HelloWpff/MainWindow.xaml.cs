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

namespace Vektorel.HelloWpff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Height = 100;
            btn.Width = 150;
            btn.Content = "Hello Wpf";
            btn.Click += Btn_Click;
            Thickness thick = new Thickness(250, 150, 0, 0);
            btn.Margin = thick;
            //btn.Margin = new Thickness(250,150,0,0);
            
            Button btn4 = new Button();
            btn4.Height = 120;
            btn4.Width = 130;
            btn4.Content = "buton 4";
            btn4.Click += Btn4_Click;
            btn4.Margin = new Thickness(-450, 150, 0, 0);

            Button btn5 = new Button();
            btn5.Margin = new Thickness(100, 50, 0, 0);
            btn5.Name = "btnBizimButon";
            btn5.Width = 200;
            btn5.Height = 50;
            btn5.Content = "yeniButon";
            grdMain.Children.Add(btn5);



            grdMain.Children.Add(btn4);
            grdMain.Children.Add(btn);


        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("buton 4");
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello Wpf!..Bye Bye Console..");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("buton 2");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ksjsjxkısks");
        }

        private void btn3_MouseMove(object sender, MouseEventArgs e)
        {
            lblDeneme.Content="mouse move çalıştı";
        }

        private void btn3_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click çalıştı");
        }
    }  
}
