using LoginDemoMaui.ViewModels.Dashboard;

namespace LoginDemoMaui.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardViewModel dashboardViewModel)
	{
		InitializeComponent();
		BindingContext= dashboardViewModel;
	}
}