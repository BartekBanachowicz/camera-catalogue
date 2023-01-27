using Banachowicz.CameraCatalogue.UI.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Banachowicz.CameraCatalogue.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Logic.Logic logic = new Logic.Logic("DAOMock.dll");

            BrandsTab.DataContext = new BrandListViewModel(logic);
            CamerasTab.DataContext = new CameraListViewModel(logic);

            BrandBox.ItemsSource = logic.GetBrands();
            CameraTypeBox.ItemsSource = Enum.GetValues(typeof(Core.CameraType));
            SensorTypeBox.ItemsSource = Enum.GetValues(typeof(Core.SensoreType));
        }
    }
}
