using Banachowicz.CameraCatalogue.Interfaces;

namespace DAOMock
{
    internal class DB : IDAO
    {
        private List<IBrand> _brands;
        private List<ICamera> _cameras;

        public DB()
        { 
            _brands = new List<IBrand>();
            _cameras = new List<ICamera>();
        }

        public IBrand AddNewBrand(IBrand brand)
        {
            throw new NotImplementedException();
        }

        public ICamera AddNewCamera(ICamera camera)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IBrand> GetAllBrands()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICamera> GetAllCameras()
        {
            throw new NotImplementedException();
        }

        public ICamera GetBrand(string ID)
        {
            throw new NotImplementedException();
        }

        public ICamera GetCamera(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
