using System.Windows;
using System.Windows.Controls;

namespace FocusWatch.Content.UI.Views
{
    public class WatchContent : ContentControl
    {
        static WatchContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WatchContent), new FrameworkPropertyMetadata(typeof(WatchContent)));
        }
    }
}
