namespace LoginDemoMaui.Controls;

public partial class FlyoutHeaderControl : StackLayout
{
	//This header control can be assigned to AppShell's Current's FlyoutHeader attribute, so user details can be seen on top of the flyout menu after login. This means this assignment will be done in LoadingPageViewModel.
	public FlyoutHeaderControl()
	{
		InitializeComponent();

		if (App.SignedInUserInfo != null)
		{
			lblUserEmail.Text = App.SignedInUserInfo.LoggedInUserEmail;
			lblUserPassword.Text = App.SignedInUserInfo.LoggedInUserPassword;
		}
	}
}