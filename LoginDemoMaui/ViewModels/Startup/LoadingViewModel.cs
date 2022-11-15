using LoginDemoMaui.Controls;
using LoginDemoMaui.Models;
using LoginDemoMaui.Views.Dashboard;
using LoginDemoMaui.Views.Startup;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoMaui.ViewModels.Startup
{
    public class LoadingViewModel
    {
        public LoadingViewModel()
        {
            //When app is first runned, then LoadingPage will be instantiated first because it is in the first place in AppShell.xaml.
            //When this LoadingViewModel is instantiated in LoadingPage.xaml.cs in line 10(thanks to line 32 in MauiProgram.cs), then this constructor will be called, so CheckUserSignInDetails method will be executed.
            //This will make it possible to go to LoginPage or DashboardPage.
            CheckUserSignInDetails();
        }

        private async void CheckUserSignInDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.SignedInUserInfo), "");

            if (string.IsNullOrWhiteSpace(userDetailsStr))
            {
                //Navigate to Login Page
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else
            {
                //User is opened the app first time, signed in (App.SignedInUserInfo is set in Login Page) and user information is shown in top of flyout menu,
                //then user closed the app and opened again, LoginViewModel code will not be executed this time so App.SignedInUserInfo will not be set, it will be null, since App.SignedInUserInfo is resetting each time app resets, then user info will not be displayed on the top of flyout menu

                //To prevent this, meaning displayin the user info in every case, following two lines are added.
                var userDetails = JsonConvert.DeserializeObject<SignedInUserInfo>(userDetailsStr);
                App.SignedInUserInfo = userDetails;

                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                //Navigate to Dashboard
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
        }
    }
}
