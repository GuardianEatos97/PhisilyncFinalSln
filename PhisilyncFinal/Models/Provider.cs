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
        public string? serviceProviderCompanyName { get; set; }
        public string? serviceProviderPractitionerName { get; set; }
        public string? serviceProviderPractitionerSurname { get; set; }
        public string? serviceProviderPractitionerEmail { get; set; }
        public string? serviceProviderPractitionerPhoneNumber { get; set; }
        public string? serviceProviderPractitionerPassword { get; set; }
        public string? serviceProviderDescription { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ServiceType>? serviceProviderServiceTypes { get; set; }

        [ForeignKey(typeof(AddressLocation))]
        public int serviceProviderLocation { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ProviderInjury>? serviceProviderInjuries { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Treatment>? serviceProviderTreatments { get; set; }

        public Provider() 
        {
            serviceProviderServiceTypes = new();
            serviceProviderInjuries = new();
            serviceProviderTreatments = new();
        }

    }
}
