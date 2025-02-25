using System.Threading.Tasks;
using YYSLS.Core.Config;
using YYSLS.Service.Interface;
using YYSLS.Service.Notification;
using YYSLS.Service.Notifier;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace YYSLS.ViewModel.Pages;

public partial class NotificationSettingsPageViewModel : ObservableObject, IViewModel
{
    public AllConfig Config { get; set; }

    private readonly NotificationService _notificationService;

    [ObservableProperty] private bool _isLoading;

    [ObservableProperty] private string _webhookStatus = string.Empty;

    public NotificationSettingsPageViewModel(IConfigService configService, NotificationService notificationService)
    {
        Config = configService.Get();
        _notificationService = notificationService;
    }

    [RelayCommand]
    private async Task OnTestWebhook()
    {
        IsLoading = true;
        WebhookStatus = string.Empty;

        var res = await _notificationService.TestNotifierAsync<WebhookNotifier>();

        WebhookStatus = res.Message;

        IsLoading = false;
    }
}
