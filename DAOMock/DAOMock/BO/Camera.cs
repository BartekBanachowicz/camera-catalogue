using Banachowicz.CameraCatalogue.Core;
using Banachowicz.CameraCatalogue.Interfaces;
using System.Xml.Linq;

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

        public Camera(int iD) 
        {
            ID = iD;
            Name = "";
            Type = CameraType.DSLR;
            SensoreType = SensoreType.APSC;
            Brand = null;
        }
    }
}