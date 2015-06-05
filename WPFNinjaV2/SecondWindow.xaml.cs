using System.Windows;
using WPFNinjaV2.ViewModel;

namespace WPFNinjaV2
{
    /// <summary>
    /// This application's main window.
    /// </summary>
    public partial class SecondWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public SecondWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
<<<<<<< HEAD

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
=======
>>>>>>> origin/JasperV2
    }
}