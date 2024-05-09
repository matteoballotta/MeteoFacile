using Microsoft.Toolkit.Uwp.Notifications;
using System;
using Windows.Storage;

namespace MeteoFacile {
    public class NotificationManager
    {

        boolean button = false;
        boolean schedule = false;
        boolean progresiveBar = false;
    
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

            if (button == true) 
            {
                builder.AddButton (new ToastButtonDismiss());
            }

            if (progressiveBar == true)
            {
                builder.AddProgressBar (new ToastProgressBar()
                {
                    Title = "Tempo rimanente",
                    Value = 0,
                    ValueStringOverride = "0%",
                    Indeterminate = false
                });
            }
            
            if (schedule == true)
            {
                builder.AddScheduledToast(new ScheduledToastNotification(
                    builder.GetToastContent().GetXml(),
                    DateTime.Now.AddSeconds(30)));

            }

            notification.Show();
        }
    }
}
