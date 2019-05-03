using System.Windows;
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
            Mediator.Instance.Register<UserWasClickedMessage>(ShowUserDetailWindow);

            Closing += WindowClosing;
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Mediator.Instance.Send(new UserClosedMainWindowMessage());
        }

        public void ShowUserDetailWindow(UserWasClickedMessage userWasClickedMessage)
        {
            CloseOldUserDetailWindowsIfOpen();

            UserDetailWindow userDetailWindow = new UserDetailWindow();
            userDetailWindow.Show();
        }

        private void CloseOldUserDetailWindowsIfOpen()
        {
            foreach (var window in Application.Current.Windows)
            {
                Window windowInstance = window as Window;
                if (windowInstance?.GetType().Name == "UserDetailWindow")
                {
                    windowInstance.Close();
                }
            }
        }
    }
}