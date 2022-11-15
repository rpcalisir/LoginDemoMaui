using LoginDemoMaui.ViewModels.Startup;

namespace LoginDemoMaui.Views.Startup;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingViewModel loadingViewModel)
	{
		InitializeComponent();
		BindingContext = loadingViewModel;
	}
}