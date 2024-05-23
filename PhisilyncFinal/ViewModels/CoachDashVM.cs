using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using PhisilyncFinal.Views;
using PhisilyncFinal.Services;
using PhisilyncFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Plugin.Maui.Calendar.Models;

namespace PhisilyncFinal.ViewModels
{
    public partial class CoachDashVM : BaseViewModel
    {


        private readonly IPageService _pageService;

        public CoachDashVM(IPageService pageService)
        {
            _pageService = pageService;
        }

        [RelayCommand]
        private async Task TappedAthlete()
        {
            await Shell.Current.GoToAsync("treatmentPage");
        }

        public void PopUpClicked(object sender, EventArgs e)
        {
            var currentPage = _pageService.GetCurrentPage();
            currentPage.ShowPopup(new TeamStatsPopUp());
        }

        

    }

}
