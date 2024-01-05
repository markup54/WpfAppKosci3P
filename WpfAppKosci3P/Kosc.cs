using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfAppKosci3P
{
    public class Kosc
    {
        public int Wartosc { get; set; }
        public BitmapImage Obraz { get; set; }
        public bool CzyZablokowana { get; set; }
        public List <BitmapImage> KosciImages { get; set; }

        public Kosc()
        {
            Wartosc = 0;
            przygotujKosc();
            Obraz = KosciImages[Wartosc];
            CzyZablokowana = false;
        }
        private void przygotujKosc()
        {
            KosciImages = new List<BitmapImage>();
            KosciImages.Add(new BitmapImage(new Uri("grafika/pusta.png", UriKind.Relative)));
            KosciImages.Add(new BitmapImage(new Uri("grafika/kosc1.png", UriKind.Relative)));
            KosciImages.Add(new BitmapImage(new Uri("grafika/kosc2.png", UriKind.Relative)));
            KosciImages.Add(new BitmapImage(new Uri("grafika/kosc3.png", UriKind.Relative)));
            KosciImages.Add(new BitmapImage(new Uri("grafika/kosc4.png", UriKind.Relative)));
            KosciImages.Add(new BitmapImage(new Uri("grafika/kosc5.png", UriKind.Relative)));
            KosciImages.Add(new BitmapImage(new Uri("grafika/kosc6.png", UriKind.Relative)));
        }
        public void losowanie()
        {
            Random random = new Random();
            if (CzyZablokowana == false)
            {
                Wartosc = random.Next(1,7);
            }
            Obraz = KosciImages[Wartosc];
        }
        public void zablokuj()
        {
            CzyZablokowana = true;  
        }
    }
}
