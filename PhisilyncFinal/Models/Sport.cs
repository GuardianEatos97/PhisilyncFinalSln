using SQLite;

namespace PhisilyncFinal.Models
{
    public class Sport
    {

        [PrimaryKey, AutoIncrement]
        public int sportID { get; set; }
        public string sportName { get; set; }
        public string sportDescription { get; set; }

    }
}