using ClassLibrary1;
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

namespace WpfApp7
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

        private void wykonaj_Click(object sender, RoutedEventArgs e)
        {
            INapisService napisService;
            if (jakiChar.Text != "")
            {
                napisService = new NapisService(textDoOperacji.Text);
                int ileLiter = napisService.ileLiterWNapisie(Convert.ToChar(jakiChar.Text));
                bool czyPalindrom = napisService.CzyPalindrom();
                String pal = "";
                if (czyPalindrom) pal = $"Napis {textDoOperacji.Text} jest palindromem. Litery {jakiChar.Text} w tekscie jest {ileLiter} razy";
                else pal = $"Napis {textDoOperacji.Text} nie jest palindromem. Litery {jakiChar.Text} w tekscie jest {ileLiter} razy";
                output.Text = pal;
            }
            else
            {
                NapisService a = new NapisService(textDoOperacji.Text);
                napisService = new NapisService(textDoOperacji.Text);
                bool czyPalindrom = napisService.CzyPalindrom();
                String pal = "";
                if (czyPalindrom) pal = $"Napis {textDoOperacji.Text} jest palindromem.";
                else pal = $"Napis {textDoOperacji.Text} nie jest palindromem.";
                output.Text = pal;
            }
        }
    }
}
