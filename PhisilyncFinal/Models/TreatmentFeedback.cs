using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class TreatmentFeedback
    {
        [PrimaryKey,AutoIncrement]
        public int treatmentFeedbackID { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int treatmentFeedbackTreatment { get; set; }
        [ForeignKey(typeof(User))]
        public int treatmentFeedbackUser { get; set; }
        public DateTime treatmentFeedbackDate { get; set; }
        public string treatmentFeedbackComment { get; set; }
        public int treatmentFeedbackRating { get; set; }
        [ForeignKey(typeof(TreatmentAction))]
        public int treatmentFeedbackTreatmentAction { get; set; }
    }
}
