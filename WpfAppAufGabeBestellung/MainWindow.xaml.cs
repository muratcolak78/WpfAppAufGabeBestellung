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
using WpfAppAufGabeBestellung.Views;

namespace WpfAppAufGabeBestellung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Produkts_Click(object sender, RoutedEventArgs e)
        {
            MainControl.Content=new ProduktUC();
        }

        private void Bestellung_Click(object sender, RoutedEventArgs e)
        {
            MainControl.Content = new BestellungsUC();
        }
    }
}