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

namespace WpfAppKosci3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BitmapImage> KosciImages { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            przygotujKosci();
        }
        private void przygotujKosci()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            List<int> wylosowane = new List<int>();
            wylosowane.Clear();
            for(int i=0;i<5;i++)
                wylosowane.Add(random.Next(1, 7));
            k1.Source = KosciImages[wylosowane[0]];
            k2.Source = KosciImages[wylosowane[1]];
            k3.Source = KosciImages[wylosowane[2]];
            k4.Source = KosciImages[wylosowane[3]];
            k5.Source = KosciImages[wylosowane[4]];
        }
    }
}
