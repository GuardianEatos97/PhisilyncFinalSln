using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class UserType
    {

        [PrimaryKey,AutoIncrement]
        public int userTypeID { get; set; }
        public string userTypeName { get; set; }
        public string userTypeDetails { get; set; }

    }
}