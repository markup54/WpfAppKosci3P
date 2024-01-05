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
        public List<Kosc> Kosci { get; set; }
        public List<Image> Images { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            przygotujKosci();
            przygotujObrazki();
        }
        private void przygotujKosci()
        {
            Kosci = new List<Kosc>();
            Kosci.Add(new Kosc());
            Kosci.Add(new Kosc());
            Kosci.Add(new Kosc());
            Kosci.Add(new Kosc());
            Kosci.Add(new Kosc());
        }

        private void przygotujObrazki()
        {
            Images = new List<Image>();
            Images.Add(k1);
            Images.Add(k2);
            Images.Add(k3);
            Images.Add(k4);
            Images.Add(k5);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           for(int i = 0; i < Kosci.Count; i++)
            {
                Kosci[i].losowanie();
                Images[i].Source = Kosci[i].Obraz;
            }
        }

        private int sumaLiczb()
        {
            int s = 0;
            foreach(Kosc k in Kosci)
            {
                s = s + k.Wartosc;
            }
            return s;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Image image = button.Content as Image;
            
            int ktory = Images.IndexOf(image);
            if (Kosci[ktory].CzyZablokowana == true)
            {
                Kosci[ktory].CzyZablokowana = false;
                image.Opacity = 1;
            }
            else
            {
                Kosci[ktory].zablokuj();
                image.Opacity = 0.3;
            }
            

        }
    }
}
