using PhisilyncFinal.Services;
using PhisilyncFinal.Models;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.ApplicationModel;

namespace PhisilyncFinal.ViewModels
{
    public partial class EditProfileVM : BaseViewModel
    {
        private LocalDb _localDb;

        private User _currentUser;

        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;

                OnPropertyChanged();
            }
        }

        private ImageSource _avatar;

        public ImageSource Avatar
        {
            get { return _avatar; }
            set
            {
                _avatar = value;
                OnPropertyChanged();
            }
        }

        public EditProfileVM()
        {
            _localDb = new();
            CurrentUser = _localDb.GetUserByID(1);
        }

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

        [RelayCommand]
        private async Task ChangeAvatar()
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Please pick a photo"
            });

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                Avatar = ImageSource.FromStream(() => stream);

            }
        }


    }
}
