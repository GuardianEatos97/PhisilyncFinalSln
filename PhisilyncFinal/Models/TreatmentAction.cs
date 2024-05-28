using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class TreatmentAction
    {
        [PrimaryKey, AutoIncrement]
        public int treatmentActionID { get; set; }
        public string treatmentActionName { get; set; }
        [TextBlob(nameof(TreatmentActionStepActionBlob))]
        public List<string> treatmentActionStepAction { get; set; }
        public int treatmentActionStepOrder { get; set; }
        public string treatmentActionCategory { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int treatmentActionTreatment { get; set; }

        public string TreatmentActionStepActionBlob { get; set; }

        public TreatmentAction()
        {
            treatmentActionStepAction = new List<string>();
        }
    }
}