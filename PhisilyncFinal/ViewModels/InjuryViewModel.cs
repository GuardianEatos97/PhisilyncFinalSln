
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public class InjuryViewModel : BaseViewModel
    {
        private LocalDb _database;
        private ObservableCollection<ProviderInjury> _injuries;

        public ObservableCollection<ProviderInjury> Injuries { get; set; }

        
        //public ObservableCollection<ProviderInjury> Injuries
        //{
        //    get => _injuries;
        //    set
        //    {
        //        _injuries = value;
        //        OnPropertyChanged();
        //    }
        //}
        public InjuryViewModel()
        {
            
            _database = new();
            Injuries = new ObservableCollection<ProviderInjury>(_database.GetInjuriesList());
        }

        public override void Initialize()
        {
            base.Initialize();
           
        }

    }
}
