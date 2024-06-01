using System;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Media;
using CommunityToolkit.Mvvm.Input;
using System.Runtime.InteropServices;


namespace PhisilyncFinal.ViewModels
{
    public partial class ProfileDetailsVM : BaseViewModel
    {
        private LocalDb _localDb;

        private User _currentUser;

        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value;
                
                OnPropertyChanged(); 
            }
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            LoadUser();
        }

        private void LoadUser()
        {
            CurrentUser = _localDb.GetUserByID(1);

        }

        public ProfileDetailsVM()
        {
            _localDb = new();
            LoadUser(); 
        }

        [RelayCommand]
        private async Task SaveChanges()
        {
            User user = _localDb.UpdateUser(CurrentUser);
        }
    }
}
