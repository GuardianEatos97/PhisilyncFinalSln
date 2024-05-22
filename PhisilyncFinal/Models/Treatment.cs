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
        public int treatmentInjury { get; set; }

        [ForeignKey(typeof(TreatmentFrequency))]
        public int treatmentTreatmentFrequency { get; set; }

        public int treatmentTreatmentFreqDimension { get; set; }
    }
}
