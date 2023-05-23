using System.Windows;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace log4net_TESTING
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog log =
            LogHelper.GetLogger();
          //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainWindow()
        {
            InitializeComponent();
            log.Info("INITIALIZATION");
            Label1.Content = log.ToString();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            log.Info("Button1 clicked");
            Label1.Content = "Info sent";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            log.Warn("Button2 clicked");
            Label1.Content = "Warn sent";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            log.Error("Button3 clicked");
            Label1.Content = "Error sent";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            log.Fatal("Button4 clicked");
            Label1.Content = "Fatal sent";
        }
    }
}
