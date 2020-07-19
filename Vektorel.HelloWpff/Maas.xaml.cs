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
    /// Interaction logic for Maas.xaml
    /// </summary>
    public partial class Maas : Window
    {
        public Maas()
        {
            InitializeComponent();
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Maaskac.Margin = new Thickness(rnd.Next((int)(grdIcerik.ActualWidth-this.Maaskac.ActualWidth)),rnd.Next((int)(grdIcerik.ActualHeight-this.Maaskac.ActualHeight)),0,0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tamamdır");
        }
    }
}
