using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LoginDemoMaui.Controls;
using LoginDemoMaui.Models;
using LoginDemoMaui.Views.Dashboard;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoMaui.ViewModels.Startup
{
    public partial class LoginViewModel : BaseViewModel
    {
        //Binded to Email textbox in Login Page
        #region Private Fields
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        #endregion

        #region Properties
        #endregion


        #region Commands

        [RelayCommand]
        async void UserLogin()
        {

            if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
            {
                //Call API to send and get user information to Firebase

                //Setting texbox values into object properties. These properties will be filled with API response.
                var userDetails = new SignedInUserInfo()
                {
                    LoggedInUserEmail = Email,
                    LoggedInUserPassword = Password
                };

                //Preferences is used like a storage in MAUI app. This means permanent values can be set from code and these values will stay there after app restart.

                //Checks if Preferences contains a property named SignedInUserInfo and deletes it, because if a user is signed out and another user signs in, old user's information might stay there if not deleted.
                //So every time login button is pressed, Preferences will be updated with signed in user information.
                //if (Preferences.ContainsKey(nameof(App.SignedInUserInfo)))
                //{
                //    Preferences.Remove(nameof(App.SignedInUserInfo));
                //}

                var userDetailsStr = JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.SignedInUserInfo), userDetailsStr);

                //Storing signedin user details in a global object, so I will be able to reach it from anywhere in app to check if a user is signed in.
                App.SignedInUserInfo = userDetails;

                //If flyoutheader was set only in here, then if an already signed in user opens the app again, LoadingPage wouldnt navigate to LoginPage, so this flyoutHeader would not be set, user information would now be seen on the top of flyout menu, thus this will be done in LoadingViewModel also.
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                //Double slash means DashboardPage will be the root page after it is opened
                //After DashboardPage is opened, LoginPage will be displayed on Flyout
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
            else
            {
                await Shell.Current.DisplayAlert("ERROR", "Enter a valid e-mail!", "OK");
            }
        }

        #endregion

        #region Public Methods
        public LoginViewModel()
        {
        }
        #endregion

        #region Private Implementation
        #endregion
    }
}
