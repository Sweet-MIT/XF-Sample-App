///
/// Copyright(c) Sweet MIT.All rights reserved.
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XF_Sample_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactView : ContentPage
    {
        public ContactView()
        {
            InitializeComponent();
            var position = new Position(35.6440, 10.9468); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Sweet MIT",
                Address = "Teboulba, Tunisia"
            };
            SweetMap.Pins.Add(pin);
            SweetMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(10)));
        }
    }
}