using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public partial class SignUpSPVM : BaseViewModel
    {
        [RelayCommand]
        private async Task ServiceDash()
        {
            await Shell.Current.GoToAsync("sPDash");
        }
    }
}
