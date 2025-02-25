using YYSLS.Service.Notification.Model;

namespace YYSLS.Service.Notification.Builder;

public interface INotificationDataBuilder<TNotificationData> where TNotificationData : INotificationData
{
    TNotificationData Build();
}
