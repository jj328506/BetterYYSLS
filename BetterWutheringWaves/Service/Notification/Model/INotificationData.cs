using YYSLS.Service.Notification.Model.Enum;
using System.Text.Json.Serialization;

namespace YYSLS.Service.Notification.Model;

public interface INotificationData
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public NotificationEvent Event { get; set; }
}
