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

namespace CassaNegozio
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
        
        private void Button_Click_Calcola(object sender, RoutedEventArgs e)
        {
            double importo = double.Parse(txt_Imp.Text);
            double s = double.Parse(txt_IvaEnable.Text);
            double prezzos;
            double sconto;
            sconto = (s / 100 * importo);
            prezzos = importo - (s / 100 * importo);
            double i = double.Parse(txt_IvaEnable.Text);
            double prezzosi;
            double iva;
            iva = (i / 100 * prezzos);
            prezzosi = prezzos + (i / 100 * prezzos);
            txt_Tot.Text = $"{prezzosi}€";
            txt_ScontoDisenable.Text = $"{sconto}€";
            txt_IVADisenable.Text = $"{iva}";
        }
    }
}
