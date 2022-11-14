using LoginDemoMaui.Handlers;
using Microsoft.Maui.Platform;

namespace LoginDemoMaui;

public partial class App : Application
{
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
