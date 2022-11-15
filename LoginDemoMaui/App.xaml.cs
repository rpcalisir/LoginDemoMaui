using LoginDemoMaui.Handlers;
using LoginDemoMaui.Models;
using Microsoft.Maui.Platform;

namespace LoginDemoMaui;

/// <summary>
/// Provides a common place for app to define properties, to be able to reach from anywhere in the app, for common use.
/// Also provides properties to save permanent values inside of them even after the app closes and opened again.
/// </summary>
public partial class App : Application
{
	//Holds the logged-in user information even after app is restarted.
	public static SignedInUserInfo SignedInUserInfo;

	public App()
	{
		InitializeComponent();

        #region Handlers
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
		{
			if (view is BorderlessEntry)
			{
#if __ANDROID__
				handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif __IOS__
				handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
			}
		});
		#endregion

        MainPage = new AppShell();
	}
}
