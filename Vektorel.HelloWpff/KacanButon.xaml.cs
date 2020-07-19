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
    /// Interaction logic for KacanButon.xaml
    /// </summary>
    public partial class KacanButon : Window
    {
        int puan;
        string txtad;
        string txtsoyad;
        public KacanButon()
        {
            InitializeComponent();
        }
        public KacanButon(string txtad, string txtsoyad)
        {
            InitializeComponent();
            lbl2.Content =$"Hoşgeldiniz  {txtad}  {txtsoyad}";

        }
            private void Button_MouseMove(object sender, MouseEventArgs e)
            {
                Random rnd = new Random();
                int sol = rnd.Next((int)grd.ColumnDefinitions[0].ActualWidth - (int)btnkacan.Width);
                int top = rnd.Next((int)grd.ActualHeight - (int)btnkacan.Height);
                btnkacan.Margin = new Thickness(sol, top, 0, 0);

                Button btn = (Button)sender;

                //if (btn.Margin.Left - btnkacan.Margin.Left > 50)
                //{
                //    puan += 10;
                //}

                //else
                //{
                //    puan++;
                //}


                puan++;

                //btnkacan.Content = puan;
                lbl.Content = puan;
                
            }
        }
    }
