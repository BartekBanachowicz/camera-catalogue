using Banachowicz.CameraCatalogue.Core;
using Banachowicz.CameraCatalogue.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Banachowicz.CameraCatalogue.DAOSql
{
    public class Camera : ICamera
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public IBrand Brand { get; set; }
        public CameraType Type { get; set; }
        public SensoreType SensoreType { get; set; }

        public Camera(string iD, string name, IBrand brand, CameraType type, SensoreType sensoreType)
        {
            ID = iD;
            Name = name;
            Brand = brand;
            Type = type;
            SensoreType = sensoreType;
        }
    }
}
