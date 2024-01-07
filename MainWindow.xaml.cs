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
namespace tegon.elettra._4i.stampante
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stampante ogg = new Stampante();
        pagina pag = new pagina();
        public MainWindow()
        {

            InitializeComponent();
            NeroRandom.Text = "Nero="+Convert.ToString(ogg.B);
            GialloRandom.Text = "Giallo=" + Convert.ToString(ogg.Y);
            MagentaRandom.Text="Magenta="+Convert.ToString(ogg.M);
            CianoRandom.Text="Ciano="+Convert.ToString(ogg.C);
            Fogli.Text = "Fogli=" + Convert.ToString(ogg.Fogli);
        }

        private void stampa1_Click(object sender, RoutedEventArgs e)
        {
            ogg.Stampa(pag);
        }

        private void stampaUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FogliInp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
