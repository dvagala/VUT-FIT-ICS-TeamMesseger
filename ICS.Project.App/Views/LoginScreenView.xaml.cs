
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using MaterialDesignThemes.Wpf;

namespace ICS.Project.App.Views
{
    /// <summary>
    /// Interaction logic for TeamDetailView.xaml
    /// </summary>
    public partial class LoginScreenView
    {
        public LoginScreenView()
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
