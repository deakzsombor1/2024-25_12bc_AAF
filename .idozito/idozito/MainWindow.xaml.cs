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

namespace idozito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int stopper_mero = 0;
        static System.Timers.Timer timer = new System.Timers.Timer();
        static bool fut_e = false;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = 10;
            timer.Elapsed += OnTimerElapsed;
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            stopper_mero += 1;
            stopper.Dispatcher.Invoke(() =>
            {
                int perc = stopper_mero / 6000;
                int masodperc = (stopper_mero % 6000) / 100;
                int szazadmp = stopper_mero % 100;
                stopper.Text = string.Format("{0:D2}:{1:D2}.{2:D2}", perc, masodperc, szazadmp);
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (fut_e)
            {
                timer.Stop();
                fut_e= false;
                indito_megallito.Content = "Folytatás";
                indito_megallito.Background = Brushes.LightGray;
            }
            else {
                timer.Start();
                fut_e = true;
                indito_megallito.Content = "Leállít";
                indito_megallito.Background = Brushes.IndianRed;
            }
        }

        private void kor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}