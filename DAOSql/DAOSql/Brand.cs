using System.ComponentModel.DataAnnotations;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class Brand : Interfaces.IBrand
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public Brand(int iD, string name, string country)
        {
            ID = iD;
            Name = name;
            Country = country;
        }

        public Brand(int ID)
        {
            this.ID = ID;
            this.Name = "";
            this.Country = "";
        }

    }
}
