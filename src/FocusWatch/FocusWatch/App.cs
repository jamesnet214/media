using FocusWatch.Content.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FocusWatch
{
    internal class App : Application
    {
        internal App()
        {
            MainWindow = new MainWindow();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow.Show();
        }
    }
}
