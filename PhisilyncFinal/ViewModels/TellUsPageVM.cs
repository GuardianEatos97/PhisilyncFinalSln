using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;


namespace PhisilyncFinal.ViewModels
{
    public partial class TellUsPageVM : BaseViewModel
    {
        [RelayCommand]
        private async Task Athlete()
        {
            await Shell.Current.GoToAsync("///athleteSignUp");
        }

        [RelayCommand]
        private async Task Coach()
        {
            await Shell.Current.GoToAsync("///coachSignUp");
        }

        [RelayCommand]
        private async Task Provider()
        {
            await Shell.Current.GoToAsync("///spSignUp");
        }
    }
}
