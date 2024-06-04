using PhisilyncFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    [QueryProperty(nameof(Data), "data")]
    public class InjuryDetailsViewModel : BaseViewModel
    {
        private ProviderInjury Data;

        public ProviderInjury _data
        {
            get { return _data; }
            set { _data = value; }
        }

        public void LoadData(ProviderInjury data)
        {
            Data = data;
            // Query the database and display the binded data
            // using the Data.Name and Data.Age properties
        }
    }
}
