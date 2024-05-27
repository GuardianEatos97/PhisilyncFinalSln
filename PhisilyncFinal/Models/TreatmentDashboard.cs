using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class TreatmentDashboard
    {

        [PrimaryKey,AutoIncrement]
        public int treatmentDashID { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int treatmentDashboardTreatment { get; set; }

        [OneToOne]
        public Treatment treatment { get; set; }

        [ForeignKey(typeof(TreatmentAction))]
        public int treatmentActionID { get; set; }

        [OneToOne]
        public TreatmentAction treatmentAction { get; set; }

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
        [OneToOne]
        public User user { get; set;}

        public DateTime treatmentDashDate { get; set; }
        public bool treatmentDashDone { get; set; }
    }
}