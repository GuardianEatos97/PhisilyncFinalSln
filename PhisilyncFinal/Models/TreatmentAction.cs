using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class TreatmentAction
    {
        [PrimaryKey, AutoIncrement]
        public int treatmentActionID { get; set; }
        public string treatmentActionName { get; set; }
        
        public string treatmentActionStepAction { get; set; }
        public int treatmentActionStepOrder { get; set; }
        public string treatmentActionCategory { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int treatmentActionTreatment { get; set; }



       
    }
}