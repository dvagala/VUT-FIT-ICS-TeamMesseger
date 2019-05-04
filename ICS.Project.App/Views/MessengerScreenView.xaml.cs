
using System.Net.Mime;
using System.Windows;

namespace ICS.Project.App.Views
{
    /// <summary>
    /// Interaction logic for TeamDetailView.xaml
    /// </summary>
    public partial class MessengerScreenView
    {
        public MessengerScreenView()
        {
            InitializeComponent();
        }
        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
