using Plugin.Maui.Calendar.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TreatmentID { get; set; }
        public DateTime EventDate { get; set; }

        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public int Frequency { get; set; }
    }
}
 