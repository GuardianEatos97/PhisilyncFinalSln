using System;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public override void OnAppearing()
        {
            base.OnAppearing();
            LoadUser();
        }

        public void LoadUser()
        {
            CurrentUser = _localDb.GetUserByID(1);

        }

    }
}
