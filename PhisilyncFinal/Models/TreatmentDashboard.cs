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

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Provider>? treatmentDashboardServiceProviders { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<BodyPart>? treatmentDashboardBodyParts { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int treatmentDashboardTreatment { get; set; }

        public TreatmentDashboard()
        { 
            treatmentDashboardServiceProviders = new(); 
            treatmentDashboardBodyParts = new();
        }

    }
}