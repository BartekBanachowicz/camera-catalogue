using Banachowicz.CameraCatalogue.Interfaces;
using System.ComponentModel;

namespace Banachowicz.CameraCatalogue.UI.ViewModel
{
    internal class BrandViewModel : INotifyPropertyChanged
    {
        private IBrand Brand;
        public event PropertyChangedEventHandler PropertyChanged;

        public BrandViewModel(IBrand brand) 
        {
            this.Brand = brand;
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Id
        {
            get => Brand.ID;
            set
            {
                Brand.ID = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string Name
        {
            get => Brand.Name;
            set
            {
                Brand.Name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Country
        {
            get => Brand.Country;
            set
            {
                Brand.Country = value;
                RaisePropertyChanged(nameof(Country));
            }
        }
    }
}
