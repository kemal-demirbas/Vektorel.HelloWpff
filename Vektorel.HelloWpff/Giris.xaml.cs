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
    /// Interaction logic for Giris.xaml
    /// </summary>
    public partial class Giris : Window
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Oyuncu oyn = new Oyuncu();
            //oyn.ad = txtad.Text;
            //oyn.soyad = txtsoyad.Text;

            KacanButon k = new KacanButon(new Oyuncu {ad=txtad.Text,soyad=txtsoyad.Text });
            k.Show();

        }
    }
}
