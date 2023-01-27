using Banachowicz.CameraCatalogue.Core;
using Banachowicz.CameraCatalogue.Interfaces;

namespace Banachowicz.CameraCatalogue.DAOMock.BO
{
    public class Camera : ICamera
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CameraType Type { get; set; }
        public SensoreType SensoreType { get; set; }
        public IBrand Brand { get; set; }

        public Camera(int iD, string name, CameraType type, SensoreType sensoreType, IBrand brand)
        {
            ID = iD;
            Name = name;
            Type = type;
            SensoreType = sensoreType;
            Brand = brand;
        }

        public Camera() { }
    }
}