using LoginDemoMaui.ViewModels;
using LoginDemoMaui.Views.Dashboard;

namespace LoginDemoMaui;

public partial class AppShell : Shell
{
	//AppShell is like the current displayed view of the app
	public AppShell()
	{
		InitializeComponent();

        //AppShell is like the current page of the app, it is binded to AppShellViewModel
        BindingContext = new AppShellViewModel();


        //This is added to make it possible to navigate between pages from viewmodel classes.
        //For example; DashboardPage is registered here, it's route is registered, so it is possible to go to this page with accessing to Shell.Current from any view model class.
        //If this routing is not added here, then following exception is thrown when a command is executed to navigato to DashboardPage:
        //Relative routing to shell elements is currently not supported. Try prefixing your uri with ///: ///DashboardPage'
        //So this is prefixing our uri with the page we want to navigate into.
        Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));



	}
}
