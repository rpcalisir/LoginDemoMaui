using CommunityToolkit.Mvvm.ComponentModel;
using LoginDemoMaui.ViewModels.Startup;

namespace LoginDemoMaui.Views.Startup;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
        BindingContext = loginViewModel;
    }
}