using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class ServiceType
    {

        [PrimaryKey,AutoIncrement]
        public int serviceTypeID { get; set; }
        public string serviceTypeName { get; set; }
        public string serviceTypeDescription { get; set; }

    }
}