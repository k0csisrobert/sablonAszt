using hegyekCLI;
using System.IO;
using System.Reflection.Metadata.Ecma335;
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

namespace hegyekWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Hegycsucs> hegyek = new List<Hegycsucs>();
        public MainWindow()
        {
            InitializeComponent();
            string[] beolvasas = File.ReadAllLines("hegyek.csv");
            

            foreach (var item in beolvasas.Skip(1))
            {
                hegyek.Add(new Hegycsucs(item));
            }

            datagrid.ItemsSource = hegyek;
        }

        private void hozzaad(object sender, RoutedEventArgs e)
        {
            try
            {
                if(0<int.Parse(magassag.Text) && int.Parse(magassag.Text)<2000)
                {
                    hegyek.Add(new Hegycsucs($"{nev.Text};{hegyseg.Text};{magassag.Text}"));
                    datagrid.Items.Refresh();
                    MessageBox.Show("Sikeres hozzáadás");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen hozzáadás");
            }
        }

        private void mentes(object sender, RoutedEventArgs e)
        {
            try
            {
                string sor = "";
                foreach (var item in hegyek)
                {
                    sor += $"{item.Nev};{item.Hegyseg};{item.Magassag}\n";

                }
                File.WriteAllText("hegcsucsok2.csv", sor);
                MessageBox.Show("A mentés sikeresen megtörtént!");
            }
            catch
            {
                MessageBox.Show("A mentés sikertelen volt!");
            }
        }
    }
}