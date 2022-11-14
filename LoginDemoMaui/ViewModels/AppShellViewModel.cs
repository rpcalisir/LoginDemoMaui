using CommunityToolkit.Mvvm.Input;
using LoginDemoMaui.Views.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoMaui.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [RelayCommand]
        async void SignOut()
        {
            await AppShell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
