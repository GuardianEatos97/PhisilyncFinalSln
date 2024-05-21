using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class UserClub
    {

        [PrimaryKey, AutoIncrement]
        public int userClubID { get; set; }

        [ForeignKey(typeof(User))]
        public int userClubUserID { get; set; }

        [ForeignKey(typeof(Club))]
        public int userClubClubID { get; set; }

    }
}
