using System.Windows;
using System.Windows.Controls;
using ICS.Project.App.ViewModels.BaseViewModels;

namespace ICS.Project.App.Views.Base
{
    public class UserControlCustom : UserControl
    {
        public UserControlCustom()
        {
            Loaded += OnLoad;
        }

        public void OnLoad(object sender, RoutedEventArgs e)
        {
            if (DataContext is IViewModel viewModel) viewModel.Load();
        }
    }
}