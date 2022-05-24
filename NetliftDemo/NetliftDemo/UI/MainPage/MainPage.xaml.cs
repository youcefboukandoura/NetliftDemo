using System;
using NetliftDemo.UI.PlacesPage;
using Xamarin.Forms;

namespace NetliftDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnOriginClick(object sender, EventArgs e)
        {
            var page = new PlacesPage();
            await Navigation.PushAsync(page);
        }

        public async void OnDestinationClick(object sender, EventArgs e)
        {
            var page = new PlacesPage();
            await Navigation.PushAsync(page);
        }


        private void CreateButton_Clicked(object sender, EventArgs e)
        {
         
        }
    }
}