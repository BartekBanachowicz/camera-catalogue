using Banachowicz.CameraCatalogue.DAOMock.BO;
using Banachowicz.CameraCatalogue.Interfaces;

namespace Banachowicz.CameraCatalogue.DAOMock
{
    internal class DB : IDAO
    {
        private List<IBrand> _brands;
        private List<ICamera> _cameras;
        private int nextCameraId = 6;
        private int nextBrandId = 4;

        public DB()
        {
            _brands = new List<IBrand>
            {
                new Brand(1, "Sony", "Japan"),
                new Brand(2, "Canon", "Japan"),
                new Brand(3, "Samsung", "South Korea")
            };

            _cameras = new List<ICamera>
            {
                new Camera(1, "Alpha 7s", Core.CameraType.Mirrorless, Core.SensoreType.Full, _brands[0]),
                new Camera(2, "Alpha 7r", Core.CameraType.Mirrorless, Core.SensoreType.Full, _brands[0]),
                new Camera(3, "Alpha 7mk2", Core.CameraType.Mirrorless, Core.SensoreType.Full, _brands[0]),
                new Camera(4, "EOS 250D", Core.CameraType.DSLR, Core.SensoreType.APSC, _brands[1]),
                new Camera(5, "Galaxy Camera", Core.CameraType.Compact, Core.SensoreType.APSC, _brands[2])
            };
        }

        public void DeleteBrand(IBrand brand)
        {
            this._brands.Remove(brand);
        }

        public void DeleteCamera(ICamera camera)
        {
            this._cameras.Remove(camera);
        }

        public IEnumerable<IBrand> GetAllBrands()
        {
            return this._brands;
        }

        public IEnumerable<ICamera> GetAllCameras()
        {
            return this._cameras;
        }

        public IBrand NewBrand()
        {
            return new Brand(nextBrandId++);
        }

        public ICamera NewCamera()
        {
            return new Camera(nextCameraId++);
        }

        public IBrand SaveBrand(IBrand brand)
        {
            this._brands.Add(brand);
            return brand;
        }

        public ICamera SaveCamera(ICamera camera)
        {
            this._cameras.Add(camera);
            return camera;
        }
    }
}
