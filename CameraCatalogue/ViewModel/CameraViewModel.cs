using Banachowicz.CameraCatalogue.Interfaces;
using System.ComponentModel;

namespace Banachowicz.CameraCatalogue.UI.ViewModel
{
    internal class CameraViewModel : INotifyPropertyChanged
    {
        private ICamera Camera;
        public event PropertyChangedEventHandler PropertyChanged;

        public CameraViewModel(ICamera Camera) 
        {
            this.Camera = Camera;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Id
        {
            get => Camera.ID;
            set
            {
                Camera.ID = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => Camera.Name;
            set
            {
                Camera.Name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public IBrand Brand
        {
            get => Camera.Brand;
            set
            {
                Camera.Brand = value;
                RaisePropertyChanged(nameof(Brand));
            }
        }

        public Core.CameraType CameraType
        {
            get => Camera.Type;
            set
            {
                Camera.Type = value;
                RaisePropertyChanged(nameof(CameraType));
            }
        }

        public Core.SensoreType SensoreType
        {
            get => Camera.SensoreType;
            set
            {
                Camera.SensoreType = value;
                RaisePropertyChanged(nameof(SensoreType));
            }
        }
    }
}
