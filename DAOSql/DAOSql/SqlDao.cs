using Banachowicz.CameraCatalogue.Interfaces;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class SqlDao : IDAO
    {
        private DatabaseContext db = new DatabaseContext();

        public void DeleteBrand(IBrand brand)
        {
            db.Brands.Remove((Brand) brand);
        }

        public void DeleteCamera(ICamera camera)
        {
            db.Cameras.Remove((Camera) camera);
        }

        public IEnumerable<IBrand> GetAllBrands()
        {
            return db.Brands;
        }

        public IEnumerable<ICamera> GetAllCameras()
        {
            return db.Cameras;
        }

        public IBrand NewBrand()
        {
            return new Brand(0);
        }

        public ICamera NewCamera()
        {
            return new Camera(0);
        }

        public IBrand SaveBrand(IBrand brand)
        {
            db.Brands.Add((Brand) brand);
            return brand;
        }

        public ICamera SaveCamera(ICamera camera)
        {
            db.Cameras.Add((Camera) camera);
            return camera;
        }
    }
}
