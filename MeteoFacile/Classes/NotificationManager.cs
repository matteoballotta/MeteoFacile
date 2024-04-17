using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Storage;

namespace MeteoFacile {
    public class NotificationManager
    {                          
        private const string ImageUri = "":

        public static void ShowToastNotification(string title, string content)
        {
            var notice = new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddText(title)
                .AddText(content);

                if (!string.isNullOrEmpty(Image))
                {
                    notice.AddHeroImage(Image);
                }

                notice.Show (toast =>
                {
                    toast.ExpirationTime = DateTime.Now.AddDays (1);
                });
        }

        public static void ShowToastNotification(string title, string content, int expiry)
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddText(title)
                .AddText(content)
                .Show(toast =>
                {
                    toast.ExpirationTime = DateTime.Now.AddDays(expiry);
                });
        }

        public static string Image {
            get {
                // Legge il percorso dell'immagine
                return ApplicationData.Current.LocalSettings.Values[ImageUri] as string;
            }

            set {
                ApplicationData.Current.LocalSettings.Values[ImageUri] = value;
            }
        }
    }
}
