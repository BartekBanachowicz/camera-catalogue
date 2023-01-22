namespace Banachowicz.CameraCatalogue.Interfaces
{
    public interface IDAO
    {
        IEnumerable<ICamera> GetAllCameras();
        IEnumerable<IBrand> GetAllBrands();

        ICamera AddNewCamera(ICamera camera);
        IBrand AddNewBrand(IBrand brand);

        ICamera GetCamera(String ID);
        ICamera GetBrand(String ID);
    }
}