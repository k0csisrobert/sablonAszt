using celloveszetCLI1;
using System.IO;
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

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<cellovo> cellovok = new List<cellovo>();
        public MainWindow()
        {
            InitializeComponent();
            var beolvasas = File.ReadAllLines("lovesek.csv");
            foreach (var item in beolvasas)
            {
                cellovok.Add(new cellovo(item));
            }

            datagrid.ItemsSource = cellovok;


        }

        private void hozzaad(object sender, RoutedEventArgs e)
        {
            try
            {
                if(int.Parse(L1.Text) > 0 && int.Parse(L1.Text) <100 &&
                    int.Parse(L2.Text)>0 && int.Parse(L2.Text)<100 &&
                    int.Parse(L3.Text) > 0 && int.Parse(L3.Text) < 100 &&
                    int.Parse(L4.Text) > 0 && int.Parse(L4.Text) < 100)
                {
                    cellovok.Add(new cellovo($"{nev.Text};{L1.Text};{L2.Text};{L3.Text};{L4.Text}"));
                    datagrid.Items.Refresh();
                    MessageBox.Show("Sikeres hozzaadas!");
                }
            }
            catch
            {
                MessageBox.Show("Sikertelen hozzaadas");
            }
        }

        private void mentes(object sender, RoutedEventArgs e)
        {
            try
            {
                string tartalom = "";
                foreach (var item in cellovok)
                {
                    tartalom += $"{item.nev};{item.L1};{item.L2};{item.L3};{item.L4}\n";
                }
                File.WriteAllText("lovesek2.csv",tartalom);
                MessageBox.Show("Sikeres mentes!");
            }
            catch
            {
                MessageBox.Show("Sikertelen mentes");
            }
        }
    }
}