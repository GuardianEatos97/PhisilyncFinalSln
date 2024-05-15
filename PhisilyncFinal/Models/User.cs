
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int userID { get; set; }

        public string userName { get; set; }
        public string userSurname { get; set; }
        public string userEmail { get; set; }
        public string? userGender { get; set; }
        public string userPassword { get; set; }
        public string? userPhoneNumber { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int? userTreatment { get; set; } //foreign key

        /*[OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Sport>? userSports { get; set; }

        public User() { userSports = new(); }
        
        public DateTime userDateOfBirth { get; set; }

        [ForeignKey(typeof(UserType))]
        public int userType { get; set; }

        [ForeignKey(typeof(Club))]
        public int userClub { get; set; }*/

    }
}
