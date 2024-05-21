using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class TreatmentFrequency
    {

        [PrimaryKey,AutoIncrement]
        public int treatmentFreqID { get; set; }

        public string treatmentFreqDescription { get; set; }

    }
}