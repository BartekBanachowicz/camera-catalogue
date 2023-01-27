using Banachowicz.CameraCatalogue.Interfaces;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class SqlDao : IDAO
    {
        private DatabaseContext db = new DatabaseContext();

        public IEnumerable<IBrand> GetAllBrands()
        {
            return db.Brands;
        }

        public IEnumerable<ICamera> GetAllCameras()
        {
            throw new NotImplementedException();
        }

        public IBrand GetBrand(int ID)
        {
            throw new NotImplementedException();
        }

        public ICamera GetCamera(int ID)
        {
            throw new NotImplementedException();
        }

        public IBrand NewBrand()
        {
            throw new NotImplementedException();
        }

        public ICamera NewCamera()
        {
            throw new NotImplementedException();
        }

        public IBrand SaveBrand(IBrand brand)
        {
            throw new NotImplementedException();
        }

        public ICamera SaveCamera(ICamera camera)
        {
            throw new NotImplementedException();
        }
    }
}
