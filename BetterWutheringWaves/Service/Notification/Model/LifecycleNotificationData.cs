using System.Text.Json.Serialization;
using YYSLS.Service.Notification.Model.Enum;

namespace YYSLS.Service.Notification.Model;

public record LifecycleNotificationData : INotificationData
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public NotificationEvent Event { get; set; }

    public static LifecycleNotificationData Test()
    {
        return new LifecycleNotificationData() { Event = NotificationEvent.Test };
    }
}
