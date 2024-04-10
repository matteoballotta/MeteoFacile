using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;

private void ShowToastNotification ( string title, string content )
{
	ToastContent content = new ToastContent () {
		Scenario = ToastScenario.Default,
		Visual = new ToastVisual () {
			BindingGeneric = new ToastBindingGeneric()
			{
				Children = {
					new AdaptiveText () { Text = title }, 
					new AdaptiveText () { Text = content }
				}
			}
		}
	};

	ToastNotificationManagerCompat.CreateToastNotifier().Show(new ToastNotification(content.GetXml()));
}
