
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
        public byte[] Avatar { get; set; }

        [ForeignKey(typeof(TreatmentDashboard))]
        public int? userTreatment { get; set; }

        [ForeignKey(typeof(UserType))]
        public int userType { get; set; }
    }
}
