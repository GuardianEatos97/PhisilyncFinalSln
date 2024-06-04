using System;
using PhisilyncFinal.ViewModels;
using PhisilyncFinal.Views;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public partial class SettingsVM : BaseViewModel
    {

        private LocalDb _localDb;

        private User _currentUser;

        private bool _isDarkTheme;

        public SettingsVM()
        {
            _localDb = new();
            CurrentUser = _localDb.GetUserByID(1);
        }


        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;

                OnPropertyChanged();
            }
        }



        public bool IsDarkTheme
        {
            get { return _isDarkTheme; }
            set
            {
                _isDarkTheme = value;
                OnPropertyChanged();

                // Change the theme when the switch is toggled
                if (_isDarkTheme)
                {
                    Application.Current.Resources["CurrentBackgroundColor"] = Application.Current.Resources["DarkBackgroundColor"];
                }
                else
                {
                    Application.Current.Resources["CurrentBackgroundColor"] = Application.Current.Resources["LightBackgroundColor"];
                }
            }
        }
    }
}
