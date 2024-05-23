using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class InjurySports
    {

        [PrimaryKey,AutoIncrement]
        public int injurySportsID { get; set; }

        [ForeignKey(typeof(ProviderInjury))]
        public int injurySportsInjury { get; set; }
        [ForeignKey(typeof(Sport))]
        public int injurySportsSport { get; set; }

    }
}
