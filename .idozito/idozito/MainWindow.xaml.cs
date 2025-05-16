using System.Diagnostics;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace idozito
{
    public partial class MainWindow : Window
    {
        private Stopwatch stopperOra = new Stopwatch();
        private DispatcherTimer frissito = new DispatcherTimer();
        private Stopwatch reszIdoStopper = new Stopwatch();
        private bool fut_e = false;

        public MainWindow()
        {
            InitializeComponent();

            frissito.Interval = TimeSpan.FromMilliseconds(10);
            frissito.Tick += Frissito_Tick;
        }

        private void Frissito_Tick(object sender, EventArgs e)
        {
            // Fo ido
            var elapsed = stopperOra.Elapsed;

            int perc = elapsed.Minutes;
            int masodperc = elapsed.Seconds;
            int szazadmp = elapsed.Milliseconds / 10;

            stopper.Text = string.Format("{0:D2}:{1:D2}.{2:D2}", perc, masodperc, szazadmp);


            // Resz ido
            var resz = reszIdoStopper.Elapsed;
            int rPerc = resz.Minutes;
            int rMasodperc = resz.Seconds;
            int rSzazad = resz.Milliseconds / 10;

            reszido.Text = string.Format("{0:D2}:{1:D2}.{2:D2}", rPerc, rMasodperc, rSzazad);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (fut_e)
            {
                reszIdoStopper.Stop();
                stopperOra.Stop();
                frissito.Stop();
                fut_e = false;
                indito_megallito.Content = "Folytatás";
                indito_megallito.Background = Brushes.LightGray;
                kor.Content = "Törlés";
                kor.Background = Brushes.IndianRed;
            }
            else
            {
                reszIdoStopper.Start();
                stopperOra.Start();
                frissito.Start();
                fut_e = true;
                indito_megallito.Content = "Leállít";
                indito_megallito.Background = Brushes.IndianRed;
                kor.Content = "Kör";
                kor.Background = Brushes.LightGreen;
            }
        }

        private void kor_Click(object sender, RoutedEventArgs e)
        {
            if (fut_e)
            {

                reszIdoStopper.Restart();
                string aktualisIdo = stopper.Text;
                string reszIdo = reszido.Text;
                listBox.Items.Insert(0, reszIdo);

            }
            else
            {
                reszIdoStopper.Reset();
                reszido.Text = "00:00.00";
                stopperOra.Reset();
                stopper.Text = "00:00.00";
                listBox.Items.Clear();
                kor.Content = "Kör";
                kor.Background = Brushes.LightGray;
                indito_megallito.Content = "Indítás";
            }
        }
    }
}