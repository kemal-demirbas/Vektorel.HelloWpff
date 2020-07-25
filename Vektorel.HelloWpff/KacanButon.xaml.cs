using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Vektorel.HelloWpff
{
    /// <summary>
    /// Interaction logic for KacanButon.xaml
    /// </summary>
    public partial class KacanButon : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int puan;
        int sayi = 5;
        Oyuncu o;

        public KacanButon()
        {
            InitializeComponent();
            OyunuBaslat();
        }
        public KacanButon(Oyuncu o)
        {
            InitializeComponent();
            this.o = o;
            lbl2.Content = $"Hoşgeldiniz  {o.ad}  {o.soyad}";
            timer.Tick += Timer_Tick;
            OyunuBaslat();
            //geriye doğru sayan saat yapıldı


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sayi == 0)
            {
                SkorKaydet(puan, DateTime.Now, o);
                timer.Stop();
                btnkacan.Visibility = Visibility.Hidden;
                MessageBoxResult cevap = MessageBox.Show($"oyun bitti\npuanınız:{puan}\nYeniden başlamak istermisiniz?", "Game Over", MessageBoxButton.YesNo);
                if (cevap == MessageBoxResult.Yes)
                {

                    OyunuBaslat();

                }
                else
                {
                    MessageBox.Show("oyun bitti");
                    //this.Close();
                    Application.Current.Shutdown();
                }
            }
            else
            {
                lbl3.Content = sayi;
                sayi--;
            }

        }

        public void OyunuBaslat()
        {
            sayi = 5;
            puan = 0;
            lbl.Content = puan;
            timer.Interval = new TimeSpan(0, 0, 1);

            timer.Start();
            btnkacan.Visibility = Visibility.Visible;
            this.WindowState = WindowState.Maximized;

            timer.Start();
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int sol = rnd.Next((int)grd.ColumnDefinitions[0].ActualWidth - (int)btnkacan.Width);
            int top = rnd.Next((int)grd.ActualHeight - (int)btnkacan.Height);
            btnkacan.Margin = new Thickness(sol, top, 0, 0);

            Button btn = (Button)sender;
            puan++;

            //btnkacan.Content = puan;
            lbl.Content = puan;

        }

        void SkorKaydet(int puan, DateTime tarih, Oyuncu o)
        {
            File.AppendAllText((@"D:\Skorlar.txt"), $"{o.ad} {o.soyad} isimli  oyuncu {tarih} tarihinde {puan} puan aldı.\r\n");
        }
    }
}
