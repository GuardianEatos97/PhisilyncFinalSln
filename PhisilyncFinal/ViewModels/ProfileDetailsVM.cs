using System;
using PhisilyncFinal.Models;
using PhisilyncFinal.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PhisilyncFinal.ViewModels
{

    public partial class ProfileDetailsVM : BaseViewModel
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public void LoadUser(int id)
        {
            var user = GetUser(id);
            if (user != null)
            {
                Users.Add(user);
            }
        }

        private User GetUser(int id)
        {
            // Implementation to get the user by id
            // Replace this with your actual implementation
            throw new NotImplementedException();
        }
    }


}

