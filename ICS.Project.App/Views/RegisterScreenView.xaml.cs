using System.Windows;
using System.Windows.Controls;
using ICS.Project.App.AttachedProperties;

namespace ICS.Project.App.Views
{
    /// <summary>
    ///     Interaction logic for RegisterScreenView.xaml
    /// </summary>
    public partial class RegisterScreenView
    {
        public RegisterScreenView()
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