using System.Windows;
using System.Windows.Controls;
using ICS.Project.App.AttachedProperties;

namespace ICS.Project.App.Views
{
    /// <summary>
    ///     Interaction logic for LoginScreenView.xaml
    /// </summary>
    public partial class LoginScreenView
    {
        public LoginScreenView()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var pBox = sender as PasswordBox;
            PasswordBoxAttachedProperty.SetEncryptedPassword(pBox, pBox.SecurePassword);
        }
    }
}