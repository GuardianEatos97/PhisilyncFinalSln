using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class Treatment
    {

        [PrimaryKey,AutoIncrement]
        public int treatmentID { get; set; }
        public string treatmentName { get; set; }
        public string treatmentDescription { get; set; }

        [ForeignKey(typeof(ProviderInjury))]
        public int treatmentInjury { get; set; } //foreign key

        /*[ForeignKey(typeof(TreatmentType))]
        public int treatmentType { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ProviderInjury>? treatmentInjury { get; set; }
        
        public Treatment() { treatmentInjury = new(); }

        [ForeignKey(typeof(Provider))]
        public int treatmentServiceProvider { get; set; }*/


    }
}
