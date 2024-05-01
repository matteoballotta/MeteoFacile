using Microsoft.Toolkit.Uwp.Notifications;
using System;
using Windows.Storage;

namespace MeteoFacile
{
    public class NotificationManager
    {
        var ImageUri = null, header, text, button, header, emoji, bar, schedule;
        var notification = new ToastContentBuilder();

        public static void ShowToastNotification(string title, string content, string imageUri = null)
        {
            notification.AddArgument("action", "viewConversation")
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

        public static Boolean addImage = false;
        public static Boolean addText = true;
        //public static void addAudio (Boolean v);
        public static Boolean addButton = false;
        public static Boolean addHeader = true;
        // public static Boolean addEmoji = false;
        public static Boolean addProgressBar = false;
        public static Boolean addSchedule = false;
        // public static void addInputTextBox (Boolean v);

        public static string Image {
            get { return ImageUri; }
            set { ImageUri = value; }
        }

        public static string Text
        {
            get { return text; }
            set { text = value; }
        }

        public static string Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public static string Bar
        {
            get { return bar; }
            set { bar = value; }
        }
        
        public static string Header
        {
            get { return header; }
            set { header = value; }
        }
        
        public static string Button
        {
            get { return bar; }
            set { button = value; }
        }

        public static void ShowToastNotification()
        {
            
            if (addButton == true)
            {
                notification.AddButton(Button);
            }
            if (addImage == true)
            {
                notification.AddHeroImage(Image);
            }
            if (addHeader == true)
            {
                notification.AddHeader(Header);
            } 
            if (addText == true)
            {
                notification.addText(Text);
            }
            if (addSchedule == true)
            {
                notification.AddSchedule(Schedule);
            }

            notification.Show();
        }

    }