using Banachowicz.CameraCatalogue.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace Banachowicz.CameraCatalogue.UI.ViewModel
{
    internal class BrandListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<BrandViewModel> Brands { get; set; } = new ObservableCollection<BrandViewModel>();
        private Logic.Logic Logic;

        private ListCollectionView _view;
        public string FilterValue {  get; set; }

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

            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(Brands);
            _filterCommand = new RelayCommand(param => FilterGrid());
            _newBrandCommand = new RelayCommand(param => AddEmptyBrand());
            _saveBrandCommand = new RelayCommand(param => SaveChanges());
            _deleteBrandCommand = new RelayCommand(param => DeleteBrand());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddEmptyBrand()
        {
            IBrand newBrand = this.Logic.NewBrand();
            BrandViewModel newBrandModel = new BrandViewModel(newBrand);
            Brands.Add(newBrandModel);
            SelectedBrand = newBrandModel;
        }

        private void SaveChanges()
        {
            Logic.SaveBrand(EditedBrand.GetBrand());
        }

        private void DeleteBrand()
        {
            Logic.DeleteBrand(EditedBrand.GetBrand());
            Brands.Remove(EditedBrand);
        }

        private void FilterGrid()
        {
            if (string.IsNullOrEmpty(FilterValue))
            {
                _view.Filter = null;
            }
            else
            {
                _view.Filter = (b) => ((BrandViewModel)b).Name.Contains(FilterValue);
            }
        }

        private RelayCommand _filterCommand;
        public RelayCommand FilterCommand
        {
            get => _filterCommand;
        }

        private RelayCommand _newBrandCommand;
        public RelayCommand NewBrandCommand
        {
            get => _newBrandCommand;
        }

        private RelayCommand _saveBrandCommand;
        public RelayCommand SaveBrandCommand
        {
            get => _saveBrandCommand;
        }

        private RelayCommand _deleteBrandCommand;
        public RelayCommand DeleteBrandCommand
        {
            get => _deleteBrandCommand;
        }

    }
}
