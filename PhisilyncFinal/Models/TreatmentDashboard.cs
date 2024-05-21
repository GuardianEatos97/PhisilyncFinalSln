using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class TreatmentDashboard
    {

        [PrimaryKey,AutoIncrement]
        public int treatmentDashID { get; set; }

        [ForeignKey(typeof(TreatmentAction))]
        public int treatmentDashboardTreatmentAction { get; set; }

        [ForeignKey(typeof(User))]
        public int treatmentDashboardUser { get; set; }
        public DateTime treatmentDashDate { get; set; }

    }
}