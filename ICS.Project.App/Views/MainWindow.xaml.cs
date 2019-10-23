using System;
using System.Windows;
using System.Windows.Threading;
using MaterialDesignThemes.Wpf;

namespace ICS.Project.App.Views
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _timerForTimeoutDialog = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnTimeoutNotificationDialogHostOpen(object sender, DialogOpenedEventArgs eventArgs)
        {
            _timerForTimeoutDialog.Tick += CloseTimeoutDialog;
            _timerForTimeoutDialog.Interval = new TimeSpan(0, 0, 1);
            _timerForTimeoutDialog.Start();
        }

        private void CloseTimeoutDialog(object sender, EventArgs e)
        {
            TimeoutNotificationDialogHost.IsOpen = false;
            _timerForTimeoutDialog.Stop();
        }
    }
}