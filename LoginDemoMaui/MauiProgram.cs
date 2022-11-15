using LoginDemoMaui.ViewModels.Dashboard;
using LoginDemoMaui.ViewModels.Operations;
using LoginDemoMaui.ViewModels.Startup;
using LoginDemoMaui.Views;
using LoginDemoMaui.Views.Dashboard;
using LoginDemoMaui.Views.Operations;
using LoginDemoMaui.Views.Startup;
using Microsoft.Extensions.Logging;

namespace LoginDemoMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//Views
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<DashboardPage>();
		builder.Services.AddSingleton<LoadingPage>();
		builder.Services.AddSingleton<EventFlyersPage>();


        //ModelViews
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<DashboardViewModel>();
        builder.Services.AddSingleton<LoadingViewModel>();
        builder.Services.AddSingleton<EventFlyersViewModel>();
		


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
