using CommunityToolkit.Mvvm.Input;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public partial class SignUpCoachVM : BaseViewModel
    {
        private LocalDb localDb;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; OnPropertyChanged(); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        [RelayCommand]
        private async void SaveCoach()
        {
            var user = new User
            {
                userName = this.Name,
                userSurname = this.Surname,
                userEmail = this.Email,
                userPassword = this.Password,
                userType = 2
            };

            localDb.SaveUser(user);

            await Shell.Current.GoToAsync("coachDash");
        }

        public SignUpCoachVM()
        {
            localDb = new();
        }
    }
}
