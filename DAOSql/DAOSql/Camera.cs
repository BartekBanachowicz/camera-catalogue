using Banachowicz.CameraCatalogue.Core;
using Banachowicz.CameraCatalogue.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class Camera : ICamera
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public CameraType Type { get; set; }
        public SensoreType SensoreType { get; set; }
        IBrand ICamera.Brand { get => Brand; set => Brand = (Brand)value;  }

        public Camera(int iD, string name, Brand brand, CameraType type, SensoreType sensoreType)
        {
            ID = iD;
            Name = name;
            Brand = brand;
            Type = type;
            SensoreType = sensoreType;
        }

        public Camera(int iD)
        {
            ID = iD;
            Name = "";
            Brand = null;
            Type = CameraType.DSLR;
            SensoreType = SensoreType.APSC;
        }
    }
}
