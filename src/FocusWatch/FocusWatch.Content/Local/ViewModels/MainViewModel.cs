using DevNcore.UI.Foundation.Mvvm;
using FocusWatch.Content.UI.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace FocusWatch.Content.Local.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private string _hour;
        private string _minute;
        private string _second;
        private string _milisecond;
        string currentTime = string.Empty;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        Stopwatch stopWatch = new Stopwatch();

        public bool TopMost { get; set; } = true;

        public string Hour
        {
            get => _hour;
            set { _hour = value; OnPropertyChanged(); }
        }

        public string Minute
        {
            get => _minute;
            set { _minute = value; OnPropertyChanged(); }
        }

        public string Second
        {
            get => _second;
            set { _second = value; OnPropertyChanged(); }
        }

        public string Millisecond
        {
            get => _milisecond;
            set { _milisecond = value; OnPropertyChanged(); }
        }

        public bool IsEnableStart { get; set; } = true;
        public bool IsEnableStop { get; set; } = false;
        public bool IsEnableReset { get; set; } = false;
        public System.Diagnostics.Stopwatch timer { get; set; } = new System.Diagnostics.Stopwatch();
        //public UserConfig cfg { get; set; } = new UserConfig();

        public ICommand StartCommand { get; init; }
        public ICommand StopCommand { get; init; }
        public ICommand ResetCommand { get; init; }
        public ICommand CloseCommand { get; init; }

        public MainViewModel()
        {
            //cfg = UserConfig.Load();
            //UserConfig.MoveWindow(this.win, cfg);

            dispatcherTimer.Tick += new EventHandler(TimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);

            StartCommand = new RelayCommand<object>(Start);
            StopCommand = new RelayCommand<object>(Stop);
            ResetCommand = new RelayCommand<object>(Reset);
            CloseCommand = new RelayCommand<object>(Close);
        }

        private void TimerTick(object? sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                TimeSpan ts = stopWatch.Elapsed;
                Hour = string.Format("{0:00}", ts.Hours);
                Minute = string.Format("{0:00}", ts.Minutes);
                Second = string.Format("{0:00}", ts.Seconds);
                Millisecond = string.Format("{0:000}", ts.Milliseconds);
            }
        }

        private void Start(object obj)
        {
            stopWatch.Start();
            dispatcherTimer.Start();
        }

        private void Stop(object obj)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
        }

        private void Reset(object obj)
        {
            stopWatch.Reset();
            Hour = "00";
            Minute = "00";
            Second = "00";
            Millisecond = "00";
        }

        private void Close(object obj)
        {
            //UserConfig.Save(win, cfg);
            Window.GetWindow(View).Close();
        }
    }
}