using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public partial class EditProfileVM
    {
        [RelayCommand]
        private async Task ProfileDetails()
        {
            await Shell.Current.GoToAsync("ProfileDetails");
        }

        [RelayCommand]
        private async Task Payments()
        {
            await Shell.Current.GoToAsync("Payment");
        }

        [RelayCommand]
        private async Task Settings()
        {
            await Shell.Current.GoToAsync("Settings");
        }
    }
}
