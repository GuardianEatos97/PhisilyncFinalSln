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
        //private LocalDb localDb;

        //private User _currentUser;

        //public User CurrentUser
        //{
        //    get { return _currentUser; }
        //    set { _currentUser = value; }
        //}

        //     public Command CreateUserCommand { get; }

        //public SignUpACVM()
        //{

        //    Routing.RegisterRoute("AthleteDash", typeof(AthleteDash));

        //    localDb = new();

        //}


        //CreateUserCommand = new Command(async () =>
        //{
        //    try
        //    {
        //        localDb.SaveUser(CurrentUser);
        //        await Shell.Current.GoToAsync("AthleteDash");
        //    }
        //    catch (Exception ex)
        //    {
        //        await Application.Current.MainPage.DisplayAlert("Profile already exists", ex.Message, "Please login");
        //    }
        //});



        [RelayCommand]
        
        public async  Task CreateUser()
        {
            //CurrentUser = new();

            //try
            //{
            //    localDb.SaveUser(CurrentUser);
                await Shell.Current.GoToAsync("athleteDash");
            //}
            //catch (Exception ex)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Profile already exists", ex.Message, "Please login");
            //}
        }

        //[RelayCommand]
        //private async void Button_Clicked_1()
        //{
        //    await Shell.Current.GoToAsync("LogInPage");
        //}
    }
}
