using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PhisilyncFinal.Models;    
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.ViewModels
{
    public partial class SPDashVM
    {
        public ObservableCollection<Event> Events { get; set; }

 = new ObservableCollection<Event>()
{
            new Event { Name = "Cool event1", Description = "This is Cool event1's description!", EventDate = DateTime.Now},
            new Event { Name = "Cool event2", Description = "This is Cool event2's description!", EventDate = DateTime.Now.AddDays(5) },
            new Event { Name = "Cool event3", Description = "This is Cool event3's description!", EventDate = DateTime.Now.AddDays(-3) },
            new Event { Name = "Cool event4", Description = "This is Cool event4's description!", EventDate = new DateTime(2020, 3, 16)}
};
    }
}
