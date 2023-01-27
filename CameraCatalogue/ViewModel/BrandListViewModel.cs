using Banachowicz.CameraCatalogue.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Banachowicz.CameraCatalogue.UI.ViewModel
{
    internal class BrandListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<BrandViewModel> Brands { get; set; } = new ObservableCollection<BrandViewModel>();
        private Logic.Logic Logic;

        private BrandViewModel _selectedBrand;
        public BrandViewModel SelectedBrand
        {
            get => _selectedBrand;
            set
            {
                _selectedBrand = value;
                EditedBrand = value;
                RaisePropertyChanged(nameof(SelectedBrand));
            }
        }

        private BrandViewModel _editedBrand;
        public BrandViewModel EditedBrand
        {
            get => _editedBrand;
            set
            {
                _editedBrand = value;
                RaisePropertyChanged(nameof(EditedBrand));
            }
        }

        public BrandListViewModel(Logic.Logic logic)
        {   
            this.Logic = logic;
            IEnumerable<IBrand> brands = logic.GetBrands();
            foreach (var brand in brands) 
            {
                Brands.Add(new BrandViewModel(brand));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddEmptyBrand()
        {
            IBrand emptyBrand  = Logic.
        }
    }
}
