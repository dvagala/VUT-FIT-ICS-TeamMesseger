
using System.Windows;
using System.Windows.Controls;

namespace ICS.Project.App.Views
{
    /// <summary>
    /// Interaction logic for TeamDetailView.xaml
    /// </summary>
    public partial class RegisterScreenView
    {
        public RegisterScreenView()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pBox = sender as PasswordBox;
            ICS.Project.App.AttachedProperties.PasswordBoxAttachedProperty.SetEncryptedPassword(pBox, pBox.SecurePassword);
        }
    }
}
