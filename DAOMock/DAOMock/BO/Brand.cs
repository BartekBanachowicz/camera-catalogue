namespace Banachowicz.CameraCatalogue.DAOMock.BO
{
    internal class Brand : Interfaces.IBrand
    {
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
