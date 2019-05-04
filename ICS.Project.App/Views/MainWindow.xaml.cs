using System;
using System.Windows;
using System.Windows.Threading;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Services;

namespace ICS.Project.App.Views
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private readonly DispatcherTimer _timerForTimeoutDialog = new DispatcherTimer();

        private void OnTimeoutNotificationDialogHostOpen(object sender, MaterialDesignThemes.Wpf.DialogOpenedEventArgs eventArgs)
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