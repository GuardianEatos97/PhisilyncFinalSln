using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class ClubSport
    {

        [PrimaryKey, AutoIncrement]
        public int clubSportID { get; set; }

        [ForeignKey(typeof(Club))]
        public int clubSportClub { get; set; }

        [ForeignKey(typeof(Sport))]
        public int clubSportSport { get; set; }

    }
}
