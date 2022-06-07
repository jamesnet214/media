using System.Windows;
using System.Windows.Controls;

namespace FocusWatch.Content.UI.Views
{
    public class MainWindow : Window
    {
        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }

        public MainWindow()
        {
            Content = new WatchContent();
        }
    }
}
