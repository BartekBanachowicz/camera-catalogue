namespace Banachowicz.CameraCatalogue.Interfaces
{
    public interface ICamera
    {
        int ID { get; set; }
        String Name { get; set; }
        IBrand Brand { get; set; }
        Core.CameraType Type { get; set; }
        Core.SensoreType SensoreType { get; set; }
    }
}
