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

        //Sets the main page of the app, meaning starting page of the app
        //This means the page in the ShellContent inside of AppShell.xaml will be the main page.
        MainPage = new AppShell();
	}
}
