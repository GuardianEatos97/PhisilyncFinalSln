using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TechnoTitansFinal.Models
{
    public class BodyPart
    {

        [PrimaryKey,AutoIncrement]
        public int bodyPartID { get; set; }
        public string bodyPartName { get; set;}
        public string bodyPartDescription { get; set;}

    }
}