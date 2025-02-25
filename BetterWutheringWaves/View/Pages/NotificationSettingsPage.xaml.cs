using System.Windows.Controls;
using YYSLS.ViewModel.Pages;

namespace YYSLS.View.Pages
{
    /// <summary>
    /// NotificationSettingsPage.xaml 的交互逻辑
    /// </summary>
    public partial class NotificationSettingsPage : Page
    {
        private NotificationSettingsPageViewModel ViewModel { get; }

        public NotificationSettingsPage(NotificationSettingsPageViewModel viewModel)
        {
            DataContext = ViewModel = viewModel;
            InitializeComponent();
        }
    }
}
