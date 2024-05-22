using CommunityToolkit.Mvvm.Input;
using PhisilyncFinal.Services;
using PhisilyncFinal.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhisilyncFinal.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PhisilyncFinal.ViewModels
{
    public partial class AthleteDashVM : BaseViewModel
    {

        //private LocalDb _database;
        //private ObservableCollection<TreatmentAction> _treatmentaction;

        //public ObservableCollection<TreatmentAction> Dashboard
        //{
        //    get => _treatmentaction;
        //    set
        //    {
        //        _treatmentaction = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public AthleteDashVM(LocalDb database)
        //{
        //    _database = database;
        //}

        //public override void Initialize()
        //{
        //    base.Initialize();
        //    Dashboard = new ObservableCollection<TreatmentAction>(_database.GetTreatmentActions());
        //}


    

        //Commands
        [RelayCommand]
        private async Task Injury()
        {
            await Shell.Current.GoToAsync("///profileDetails");
        }

        [RelayCommand]
        private async Task AthleteInjury()
        {
            await Shell.Current.GoToAsync("///treatmentPage");
        }
    }
}
