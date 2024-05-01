using Microsoft.Toolkit.Uwp.Notifications;
using System;
using Windows.Storage;

namespace MeteoFacile {
    public class NotificationManager
    {
        public static void ShowToastNotification(string title, string content, string imageUri = null)
        {
            var notification = new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddText(title)
                .AddText(content);

                if (!string.IsNullOrEmpty(imageUri))
                {
                    try
                    {
                        notification.AddHeroImage(new System.Uri(imageUri));
                    }
                    catch
                    {
                        Console.WriteLine("Immagine non trovata!");
                    }
                    
                }

                notification.Show();
        }
    }
}
