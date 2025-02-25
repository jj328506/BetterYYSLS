﻿using System;
using System.Drawing;
using YYSLS.GameTask.Common;
using YYSLS.Service.Notification.Builder;
using YYSLS.Service.Notification.Model;

namespace YYSLS.Service.Notification;

public class NotificationHelper
{
    public static void Notify(INotificationData notificationData)
    {
        NotificationService.Instance().NotifyAllNotifiers(notificationData);
    }

    public static void SendTaskNotificationUsing(Func<TaskNotificationBuilder, INotificationData> builderFunc)
    {
        var builder = new TaskNotificationBuilder();
        Notify(builderFunc(builder));
    }

    public static void SendTaskNotificationWithScreenshotUsing(Func<TaskNotificationBuilder, INotificationData> builderFunc)
    {
        var builder = new TaskNotificationBuilder();
        var screenShot = (Bitmap)TaskControl.GetRectAreaFromDispatcher().SrcBitmap.Clone();
        Notify(builderFunc(builder.WithScreenshot(screenShot)));
    }
}
