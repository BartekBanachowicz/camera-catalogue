namespace Banachowicz.CameraCatalogue.Interfaces
{
    public interface IDAO
    {
        IEnumerable<ICamera> GetAllCameras();
        IEnumerable<IBrand> GetAllBrands();

        ICamera SaveCamera(ICamera camera);
        IBrand SaveBrand(IBrand brand);

        ICamera NewCamera();
        IBrand NewBrand();

        void DeleteBrand(IBrand brand);
        void DeleteCamera(ICamera camera);
    }
}