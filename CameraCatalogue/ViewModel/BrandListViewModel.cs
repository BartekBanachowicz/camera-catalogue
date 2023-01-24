using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Banachowicz.CameraCatalogue.UI.ViewModel
{
    internal class BrandListViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<BrandViewModel> observableBrands = new ObservableCollection<BrandViewModel>();
        public ObservableCollection<BrandViewModel> Brands 
        {
            get => Brands;
            set
            {
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
