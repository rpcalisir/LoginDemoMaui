using LoginDemoMaui.ViewModels.Operations;

namespace LoginDemoMaui.Views.Operations;

public partial class EventFlyersPage : ContentPage
{
	public EventFlyersPage(EventFlyersViewModel eventFlyersViewModel)
	{
		InitializeComponent();
		BindingContext = eventFlyersViewModel;
	}
}