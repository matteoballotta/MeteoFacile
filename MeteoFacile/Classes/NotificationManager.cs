using Microsoft.Toolkit.Uwp.Notifications;

namespace MeteoFacile
{
    public class NotificationManager
    {
        public static void ShowToastNotification(string title, string content)
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddText(title)
                .AddText(content)
                .Show();
        }
    }
}
