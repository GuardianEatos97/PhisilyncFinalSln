using SQLite;

namespace TechnoTitansFinal.Models
{
    public class Sport
    {

        [PrimaryKey, AutoIncrement]
        public int sportID { get; set; }
        public string sportName { get; set; }
        public string sportDescription { get; set; }

    }
}