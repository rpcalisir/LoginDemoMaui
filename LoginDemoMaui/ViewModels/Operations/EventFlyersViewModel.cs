using CommunityToolkit.Mvvm.Input;
using LoginDemoMaui.Views.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoMaui.ViewModels.Operations
{
    public partial class EventFlyersViewModel : BaseViewModel
    {
        #region Private Fields
        #endregion

        #region Properties
        #endregion

        #region Commands
        //[RelayCommand]
        //async void GoToEventsPage()
        //{
        //    await AppShell.Current.GoToAsync($"//{nameof(EventFlyersPage)}");
        //}

        #endregion

        #region Public Methods
        public EventFlyersViewModel()
        {
            Title = "EVENTS LIST";
        }
        #endregion

        #region Private Implementation
        #endregion
    }
}
