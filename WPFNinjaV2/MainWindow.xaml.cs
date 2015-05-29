using System.Windows;
using System.Windows.Controls;
using WPFNinjaV2.ViewModel;

namespace WPFNinjaV2
{
    /// <summary>
    /// This application's main window.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        public void listItemClick(object sender, RoutedEventArgs e)
        {
            DataGrid grid = (DataGrid)sender;
            StackPanel panel = (StackPanel)grid.Parent;

            foreach(FrameworkElement item in ((StackPanel)grid.Parent).Children)
            {
                if(item is Button)
                {
                    if(item.Name == "Add")
                    {
                        if(item.IsEnabled)
                        {
                            item.IsEnabled = !item.IsEnabled;
                        }
                    }
                }
            }
        }

        public void ClearClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Grid g = (Grid)b.Parent;

            foreach(FrameworkElement item in g.Children)
            {
                if(item is Button)
                {
                    if(item.Name == "Add")
                    {
                        if(!item.IsEnabled)
                        {
                            item.IsEnabled = !item.IsEnabled;
                        }
                    }
                }
            }
        }
    }
}