using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnoTitansFinal.Models
{
    public class ProviderInjury
    {

        [PrimaryKey,AutoIncrement]
        public int providerInjuryID { get; set; }
        public string providerInjuryName { get; set; }
        public string providerInjuryDescription { get; set; }

        [ForeignKey(typeof(BodyPart))]
        public int providerInjuryBodyPart { get; set; }

        [ForeignKey(typeof(Provider))]
        public int providerInjuryServiceProvider { get; set; }

    }
}
