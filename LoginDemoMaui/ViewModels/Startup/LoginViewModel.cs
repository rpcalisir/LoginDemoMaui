using CommunityToolkit.Mvvm.Input;
using LoginDemoMaui.Views.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoMaui.ViewModels.Startup
{
    public partial class LoginViewModel : BaseViewModel
    {
        #region Private Fields
        #endregion

        #region Properties
        #endregion


        #region Commands

        [RelayCommand]
        async void UserLogin()
        {
            //Double slash means DashboardPage will be the root page after it is opened
            //After DashboardPage is opened, LoginPage will be displayed on Flyout
            await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
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
