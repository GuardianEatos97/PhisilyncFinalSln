using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TechnoTitansFinal.Models
{
    public class Club
    {

        [PrimaryKey,AutoIncrement]
        public int clubID { get; set; }
        public string clubName { get; set; }
        public string clubDescription { get; set; }

        [ForeignKey(typeof(AddressLocation))]
        public int clubLocation { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Sport>? clubSports { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<User>? clubUsers { get; set; }

        public Club() 
        {
            clubSports = new();
            clubUsers = new();
        }
    }
}
