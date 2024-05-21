using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteNetExtensions.Attributes;
using System.Threading.Tasks;

namespace PhisilyncFinal.Models
{
    public class Provider
    {
        [PrimaryKey,AutoIncrement]
        public int serviceProviderID { get; set; }

        [ForeignKey(typeof(ServiceType))]
        public int serviceProviderServiceType { get; set; }

        public string? serviceProviderCompanyName { get; set; }
        public string? serviceProviderPractitionerName { get; set; }
        public string? serviceProviderPractitionerSurname { get; set; }
        public string? serviceProviderPractitionerEmail { get; set; }
        public string? serviceProviderPractitionerPhoneNumber { get; set; }
        public string? serviceProviderPractitionerPassword { get; set; }
        public string? serviceProviderDescription { get; set; }

    }
}
