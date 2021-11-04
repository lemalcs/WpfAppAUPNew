using System.Windows;
using AutoUpdaterDotNET;

namespace WpfAppAUP
{
    /// <summary>
    /// Main Window
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked the button", "AUtoUpdate", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AutoUpdater.RunUpdateAsAdmin = false;
            AutoUpdater.Start(@"AppAUPUpdater.xml");
        }
    }
}
