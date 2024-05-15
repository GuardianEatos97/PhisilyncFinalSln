/*using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class UserType
    {
        [PrimaryKey,AutoIncrement]
        public int userTypeID { get; set; }
        public string userTypeName { get; set; }
        public string userTypeDetails { get; set; }
        public bool isCoach { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Treatment>? userTypeTreatment { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ProviderInjury>? userTypeInjury { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<TreatmentAction>? userTreatmentAction { get; set; }

        public UserType() 
        {
            userTypeTreatment = new();
            userTypeInjury = new();
            userTreatmentAction = new();
        }

        [ForeignKey(typeof(TreatmentDashboard))]
        public int userTreatmentDashboard { get; set; }

    }
}*/