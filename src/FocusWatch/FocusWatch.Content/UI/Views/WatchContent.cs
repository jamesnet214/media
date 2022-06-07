using DevNcore.WPF.Controls;
using FocusWatch.Content.Local.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FocusWatch.Content.UI.Views
{
    public class WatchContent : DevNcoreContent
    {
        static WatchContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WatchContent), new FrameworkPropertyMetadata(typeof(WatchContent)));
        }

        public WatchContent()
        {
            DataContext = new MainViewModel();
        }

        public override void OnApplyTemplate()
        {
            if (GetTemplateChild("PART_Border") is Border border)
            {
                border.MouseLeftButtonDown += Border_MouseLeftButtonDown;
            }
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            try
            {
                Window.GetWindow(this).DragMove();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }
    }
}
