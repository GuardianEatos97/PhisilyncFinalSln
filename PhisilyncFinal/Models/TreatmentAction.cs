﻿using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class TreatmentAction
    {
        
        [PrimaryKey,AutoIncrement]
        public int treatmentActionID { get; set; }

        public int treatmentInjury { get; set; }
        public string treatmentActionStepAction { get; set; }
        public int treatmentActionStepOrder { get; set; }

        [ForeignKey(typeof(Treatment))]
        public int treatmentActionTreatment { get; set; }

        [ForeignKey(typeof(TreatmentFrequency))]
        public int treatmentActionFrequency { get; set; }

    }
}