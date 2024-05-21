using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class UserSport
    {

        [PrimaryKey, AutoIncrement]
        public int userSportID { get; set; }

        [ForeignKey(typeof(User))]
        public int userSportUser { get; set; }

        [ForeignKey(typeof(Sport))]
        public int userSportSport { get; set; }

    }
}
