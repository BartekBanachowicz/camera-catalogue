using Banachowicz.CameraCatalogue.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace Banachowicz.CameraCatalogue.UI.ViewModel
{
    class CameraListViewModel
    {
        public ObservableCollection<CameraViewModel> Cameras { get; set; } = new ObservableCollection<CameraViewModel>();
        private Logic.Logic Logic;

        private ListCollectionView _view;
        public string FilterValue { get; set; }

        private CameraViewModel _selectedCamera;
        public CameraViewModel SelectedCamera
        {
            get => _selectedCamera;
            set
            {
                _selectedCamera = value;
                RaisePropertyChanged(nameof(SelectedCamera));
            }
        }

        public CameraListViewModel(Logic.Logic logic)
        {
            this.Logic = logic;
            IEnumerable<ICamera> cameras = logic.GetCameras();
            foreach (var camera in cameras)
            {
                Cameras.Add(new CameraViewModel(camera));
            }

            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(Cameras);
            _filterCommand = new RelayCommand(param => FilterGrid());
            _newCameraCommand = new RelayCommand(param => AddEmptyCamera());
            _saveCameraCommand = new RelayCommand(param => SaveChanges());
            _deleteCameraCommand = new RelayCommand(param => DeleteCamera());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddEmptyCamera()
        {
            ICamera newCamera = this.Logic.NewCamera();
            CameraViewModel newCameraModel = new CameraViewModel(newCamera);
            Cameras.Add(newCameraModel);
        }

        private void SaveChanges()
        {
            Logic.SaveCamera(SelectedCamera.GetCamera());
        }

        private void DeleteCamera()
        {
            Logic.DeleteCamera(SelectedCamera.GetCamera());
            Cameras.Remove(SelectedCamera);
        }

        private void FilterGrid()
        {
            if (string.IsNullOrEmpty(FilterValue))
            {
                _view.Filter = null;
            }
            else
            {
                _view.Filter = (b) => ((CameraViewModel)b).Name.Contains(FilterValue);
            }
        }

        private RelayCommand _filterCommand;
        public RelayCommand FilterCommand
        {
            get => _filterCommand;
        }

        private RelayCommand _newCameraCommand;
        public RelayCommand NewCameraCommand
        {
            get => _newCameraCommand;
        }

        private RelayCommand _saveCameraCommand;
        public RelayCommand SaveCameraCommand
        {
            get => _saveCameraCommand;
        }

        private RelayCommand _deleteCameraCommand;
        public RelayCommand DeleteCameraCommand
        {
            get => _deleteCameraCommand;
        }
    }
}
