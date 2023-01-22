using System.ComponentModel.DataAnnotations;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class Brand : Interfaces.IBrand
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Brand(string iD, string name, string country)
        {
            ID = iD;
            Name = name;
            Country = country;
        }
    }
}
