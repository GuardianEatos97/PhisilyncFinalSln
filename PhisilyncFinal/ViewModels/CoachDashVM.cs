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
using System.Collections.ObjectModel;

namespace PhisilyncFinal.ViewModels
{
    public partial class CoachDashVM : BaseViewModel
    {

        public ObservableCollection<Event> Events { get; set; }

 = new ObservableCollection<Event>()
{
            new Event { Name = "Cool event1", Description = "This is Cool event1's description!", EventDate = DateTime.Now},
            new Event { Name = "Cool event2", Description = "This is Cool event2's description!", EventDate = DateTime.Now.AddDays(5) },
            new Event { Name = "Cool event3", Description = "This is Cool event3's description!", EventDate = DateTime.Now.AddDays(-3) },
            new Event { Name = "Cool event4", Description = "This is Cool event4's description!", EventDate = new DateTime(2020, 3, 16)}
};


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
