using Banachowicz.CameraCatalogue.Core;
using Banachowicz.CameraCatalogue.Interfaces;

namespace Banachowicz.CameraCatalogue.DAOMock.BO
{
    public class Camera : ICamera
    {
        public string ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CameraType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public SensoreType SensoreType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IBrand Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}