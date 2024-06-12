using CommunityToolkit.Mvvm.Input;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using PhisilyncFinal.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public partial class SignUpACVM : BaseViewModel
    {
        private LocalDb localDb;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private bool _isNameValid;
        public bool IsNameValid
        {
            get { return _isNameValid; }
            set { _isNameValid = value; OnPropertyChanged(); }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; OnPropertyChanged(); }
        }

        private bool _isSurnameValid;
        public bool IsSurnameValid
        {
            get { return _isSurnameValid; }
            set { _isSurnameValid = value; OnPropertyChanged(); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        private bool _isEmailValid;

        public bool IsEmailValid
        {
            get { return _isEmailValid; }
            set { _isEmailValid = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        private bool _isPasswordValid;
        public bool IsPasswordValid
        {
            get { return _isPasswordValid; }
            set { _isPasswordValid = value; OnPropertyChanged(); }
        }

        private bool _isConfirmedPasswordValid;

        public bool IsConfirmedPasswordValid
        {
            get { return _isConfirmedPasswordValid; }
            set { _isConfirmedPasswordValid = value; }
        }


        [RelayCommand]
        private async void SaveAthlete()
        {
            if (IsEmailValid && IsNameValid && IsPasswordValid && IsSurnameValid && IsConfirmedPasswordValid)
            {
                var user = new User
                {
                    userName = this.Name, 
                    userSurname = this.Surname,
                    userEmail = this.Email,
                    userPassword = this.Password,
                    userType = 1
                };

                localDb.SaveUser(user);

                await Shell.Current.GoToAsync("athleteDash");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Invalid Input", "Please enter valid input", "OK");
            }
        }

        public SignUpACVM()
        {
            localDb = new();
        }
    }
}
