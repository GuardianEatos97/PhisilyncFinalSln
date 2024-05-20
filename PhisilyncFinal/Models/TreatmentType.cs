using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class TreatmentType
    {

        [PrimaryKey,AutoIncrement]
        public int treatmentTypeID { get; set; }
        public string treatmentTypeName { get; set; }
        public string treatmentTypeDescription { get; set; }

    }
}