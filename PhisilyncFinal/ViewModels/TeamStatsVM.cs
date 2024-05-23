using System;
using PhisilyncFinal.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{


    public class TeamStatsVM : IPageService
    {
        public Page GetCurrentPage()
        {
            return Application.Current.MainPage;
        }
    }
}
