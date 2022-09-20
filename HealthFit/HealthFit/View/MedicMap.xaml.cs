using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;
using HealthFit.ViewModel;

namespace HealthFit.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MedicMap : ContentPage
    {
        MedicMapViewModel medicMapViewModel;
        public MedicMap()
        {
            InitializeComponent();

            BindingContext = medicMapViewModel = new MedicMapViewModel();

            var positions = new Position(46.57178, 26.92236);
            MedicsMap.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(3000)));
        }
       
        #region ToolbarItems
        private async void SpitaleToolbarItem_Clicked(object sender, EventArgs e)
        {
            var contents = await medicMapViewModel.LoadSpitale();
            if (contents != null)
            {
                foreach (var item in contents)
                {
                    Pin SpitalePins = new Pin()
                    {
                        Label = item.Name,
                        Address = item.Address,
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("hospitalMap.png")
                                    : BitmapDescriptorFactory.FromView(new Image() { Source = "hospitalMap.png", WidthRequest = 64, HeightRequest = 64 }),
                        Position = new Position(item.Latitude, item.Longitude),
                        Tag = "id_hospital",
                        Type = PinType.Place,
                    };
                    MedicsMap.Pins.Add(SpitalePins);
                }
            }
            var positions = new Position(46.57178, 26.92236);
            MedicsMap.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(3000)));
        }
        private async void MedicaleToolbarItem_Clicked(object sender, EventArgs e)
        {
            var contents = await medicMapViewModel.LoadAnalize();
            if (contents != null)
            {
                foreach (var item in contents)
                {
                    Pin AnalizePins = new Pin()
                    {
                        Label = item.Name,
                        Address = item.Address,
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("clinicMap.png")
                                    : BitmapDescriptorFactory.FromView(new Image() { Source = "clinicMap.png", WidthRequest = 64, HeightRequest = 64 }),
                        Position = new Position(item.Latitude, item.Longitude),
                        Tag = "id_analize",
                        Type = PinType.Place,
                    };
                    MedicsMap.Pins.Add(AnalizePins);
                }
            }
            var positions = new Position(46.57178, 26.92236);
            MedicsMap.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(3000)));
        }
        private async void DentistToolbarItem_Clicked(object sender, EventArgs e)
        {
            var contents = await medicMapViewModel.LoadDentists();
            if (contents != null)
            {
                foreach (var item in contents)
                {
                    Pin DentistPins = new Pin()
                    {
                        Label = item.Name,
                        Address = item.Address,
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("dentistMap.png")
                                    : BitmapDescriptorFactory.FromView(new Image() { Source = "dentistMap.png", WidthRequest = 64, HeightRequest = 64 }),
                        Position = new Position(item.Latitude, item.Longitude),
                        Tag = "id_dentist",
                        Type = PinType.Place,
                    };
                    MedicsMap.Pins.Add(DentistPins);
                }
            }
            var positions = new Position(46.57178, 26.92236);
            MedicsMap.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(3000)));
        }
        private async void PharmacyToolbarItem_Clicked(object sender, EventArgs e)
        {
            var contents = await medicMapViewModel.LoadPharmacy();
            if (contents != null)
            {
                foreach (var item in contents)
                {
                    Pin PharmacyPins = new Pin()
                    {
                        Label = item.Name,
                        Address = item.Address,
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("pharmacyMap.png")
                                    : BitmapDescriptorFactory.FromView(new Image() { Source = "pharmacyMap.png", WidthRequest = 64, HeightRequest = 64 }),
                        Position = new Position(item.Latitude, item.Longitude),
                        Tag = "id_pharmacy",
                        Type = PinType.Place,
                    };
                    MedicsMap.Pins.Add(PharmacyPins);
                }
            }
            var positions = new Position(46.57178, 26.92236);
            MedicsMap.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(3000)));
        }
        private async void OftalmologiceToolbarItem_Clicked(object sender, EventArgs e)
        {
            var contents = await medicMapViewModel.LoadEyes();
            if (contents != null)
            {
                foreach (var item in contents)
                {
                    Pin EyePins = new Pin()
                    {
                        Label = item.Name,
                        Address = item.Address,
                        Icon = (Device.RuntimePlatform == Device.Android) ? BitmapDescriptorFactory.FromBundle("eyeMap.png")
                                    : BitmapDescriptorFactory.FromView(new Image() { Source = "eyeMap.png", WidthRequest = 64, HeightRequest = 64 }),
                        Position = new Position(item.Latitude, item.Longitude),
                        Tag = "id_eye",
                        Type = PinType.Place,
                    };
                    MedicsMap.Pins.Add(EyePins);
                }
            }
            var positions = new Position(46.57178, 26.92236);
            MedicsMap.MoveToRegion(MapSpan.FromCenterAndRadius(positions, Distance.FromMeters(3000)));
        }
        #endregion
    }
}