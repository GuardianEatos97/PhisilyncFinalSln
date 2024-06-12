 using CommunityToolkit.Mvvm.Input;

using PhisilyncFinal.Services;

using PhisilyncFinal.Models;
using System.Collections.ObjectModel;

using Plugin.Maui.Calendar.Models;
using System.ComponentModel;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui;
using PhisilyncFinal.Views;
using MauiPopup;

namespace PhisilyncFinal.ViewModels
{

    public partial class AthleteDashVM : BaseViewModel,INotifyPropertyChanged
    {

        private LocalDb db;
        
      

        private TreatmentAction? _injuryTestDetails;

        public TreatmentAction? InjuryTestDetails
        {
            get { return _injuryTestDetails; }
            set { _injuryTestDetails = value; }
        }

        public User _currentUser;
        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;

                OnPropertyChanged();
            }
        }

        private InjuryViewModel _injuryViewModel;
        public InjuryViewModel InjuryVM
        {
            get { return _injuryViewModel; }
            set
            {
                _injuryViewModel = value;

                OnPropertyChanged();
            }
        }

        private EventCollection events;
        public EventCollection Events
        {
            get { return events; }
            set
            {
                events = value;

                OnPropertyChanged();
            }
        }

        private ObservableCollection<Event> _todayevents;
        public ObservableCollection<Event> TodayEvents { get { return _todayevents; } set {_todayevents=value; OnPropertyChanged(); } }

        public bool animation = false;

        public List<Event> TodayTest { get; set; }
        public List<Event> TodayRelease { get; set; }
       
        public ObservableCollection<Event> TreatmentEvents { get; set; }

        private IPopupService _popupservice;



        public AthleteDashVM(InjuryViewModel injuryViewModel,IPopupService popupService)
        {

            InjuryVM = injuryViewModel;
            _popupservice=popupService;
            db = new();
            OnAppearing();
           
        }

        public override void OnAppearing()
        { 
            base.OnAppearing();
            TreatmentEvents = new ObservableCollection<Event>(db.GetCurrentTreatment());
            TodayEvents = new ObservableCollection<Event>(db.GetCurrentTreatmentByID());
            AddTodayEvents();
            Events = new EventCollection();
            AddEvents();
           
          

        }






        //Commands
      
        
        
        [RelayCommand]
        public async Task Lenny()
        {
            await Shell.Current.GoToAsync("QuestionPage");
        }

        [RelayCommand]
        public async Task Popup() 
        {
        await PopupAction.DisplayPopup(new FAQs());
        }
        [RelayCommand]
        private async Task Injury()
        {
            await Shell.Current.GoToAsync("SelectInjury");
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

        public void AddTodayEvents() 
        {
            foreach (var treatment in db.GetCurrentTreatment().Where(x => x.EventDate == DateTime.Now.AddDays(0)))
            { 
            TodayEvents.Add(treatment);
            };
        }


        public void AddEvents()
        {

            foreach (var treatment in db.GetCurrentTreatment())
            {
                if (!Events.ContainsKey(treatment.EventDate))
                {
                    Events.Add(treatment.EventDate, new List<Event> { treatment });
                }
                else
                {
                    List<Event> name = (List<Event>)Events[treatment.EventDate];
                    name.Add(treatment);
                    Events[treatment.EventDate] = name;
                }

            }

            

        }


    }
}
