using Microsoft.Toolkit.Uwp.Notifications
namespace MeteoFacile {
	private void ShowToastNotification ( string title, string content ) {
		// Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
		new ToastContentBuilder()
		    .AddArgument("action", "viewConversation")
		    .AddText(title)
		    .AddText(content)
		    .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 6 (or later), then your TFM must be net6.0-windows10.0.17763.0 or greater
	
	}
}
