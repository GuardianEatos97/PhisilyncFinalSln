using PhisilyncFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using PhisilyncFinal.Models;

namespace PhisilyncFinal.ViewModels
{
    public class TreatmentPageVM : BaseViewModel
    {

        private LocalDb _database;
        private ObservableCollection<Treatment> _treatments;

        public ObservableCollection<Treatment> Treatments
        {
            get => _treatments;
            set
            {
                _treatments = value;
                OnPropertyChanged();
            }
        }

        public TreatmentPageVM(LocalDb database)
        {
            _database = database;
        }

        public override void Initialize()
        {
            base.Initialize();
            Treatments = new ObservableCollection<Treatment>(_database.GetTreatmentsList());
        }

        
    }
}
