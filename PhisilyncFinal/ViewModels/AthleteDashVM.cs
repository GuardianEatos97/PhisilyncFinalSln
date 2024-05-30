 using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
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
using System.Windows.Input;

namespace PhisilyncFinal.ViewModels
{
    
    public partial class AthleteDashVM : BaseViewModel 
    {
        private InjuryViewModel _injuryViewModel;

        public InjuryViewModel InjuryVM
        {
            get { return _injuryViewModel; }
            set { _injuryViewModel = value;

                OnPropertyChanged();
            }
        }

        private ObservableCollection<Event> _events;

        public ObservableCollection<Event> Events
        {
            get { return _events; }
            set { _events = value;

                OnPropertyChanged();
            }
        }




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

        public AthleteDashVM(InjuryViewModel injuryViewModel)
        {
            // _database = database;
            InjuryVM = injuryViewModel;

            Events = new ObservableCollection<Event>()
        {
            new Event { Name = "Cool event1", Description = "This is Cool event1's description!", EventDate = DateTime.Now},
            new Event { Name = "Cool event2", Description = "This is Cool event2's description!", EventDate = DateTime.Now.AddDays(5) },
            new Event { Name = "Cool event3", Description = "This is Cool event3's description!", EventDate = DateTime.Now.AddDays(-3) },
            new Event { Name = "Cool event4", Description = "This is Cool event4's description!", EventDate = new DateTime(2020, 3, 16)}
        };


        }

        //public override void Initialize()
        //{
        //    base.Initialize();
        //    Dashboard = new ObservableCollection<TreatmentAction>(_database.GetTreatmentActions());
        //}




        //Commands
        [RelayCommand]
        private async Task Injury()
        {
            await Shell.Current.GoToAsync("Library");
        }

        [RelayCommand]
        private async Task AthleteInjury()
        {
            await Shell.Current.GoToAsync("treatmentPage");
        }

        [RelayCommand]
        private async Task OnAvatarTapped()
        {
            await Shell.Current.GoToAsync("EditProfile");
        }

        
    }




}
