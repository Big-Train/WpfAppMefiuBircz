using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppMefiuBircz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int xd = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void jeden_Checked(object sender, RoutedEventArgs e)
        {
            teksikxd.Text = "jeden";
            teksikxd.Foreground = jeden.Foreground;
        }

        private void dwa_Checked(object sender, RoutedEventArgs e)
        {
            teksikxd.Text = "dwa";
            teksikxd.Foreground = dwa.Foreground;
        }

        private void trzy_Checked(object sender, RoutedEventArgs e)
        {
            teksikxd.Text = "trz";
            teksikxd.Foreground = trzy.Foreground;
        }

        private void guzikens_Checked(object sender, RoutedEventArgs e)
        {
            if (xd == 0)
            {
                obrazekxd.Source = new BitmapImage(new Uri("zdj.jpg", UriKind.Relative)); xd = 1;
            }
            else 
            {
                obrazekxd.Source = new BitmapImage(new Uri("chipi.jpg", UriKind.Relative)); xd=0;
            }
        }
    }
}