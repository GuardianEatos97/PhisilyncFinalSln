using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TechnoTitansFinal.Models
{
    public class TreatmentFrequency
    {

        [PrimaryKey,AutoIncrement]
        public int treatmentFreqID { get; set; }

        public string treatmentFreqDescription { get; set; }

        [ForeignKey(typeof(TreatmentAction))]
        public int treatmentFreqTreatmentAction { get; set; }

    }
}