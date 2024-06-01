using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class Payments
    {
        public decimal CoursePrice { get; set; }
        public string CourseName { get; set; }
        public string CourseDuration { get; set; }
        public string CourseDescription { get; set; }
        public string PaymentFrequency { get; set; }
        public decimal Savings { get; set; }
        public string PremiumImage { get; set; }
    }
}
