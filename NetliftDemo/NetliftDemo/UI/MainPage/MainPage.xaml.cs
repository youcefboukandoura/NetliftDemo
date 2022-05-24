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

        public async void OnOriginClick()
        {
            Console.WriteLine("**** Hi mate");
            Console.Out.WriteLine(" on origin click");
            PlacesPage page = new PlacesPage();
            await Navigation.PushAsync(page);
        }


        async void CreateButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("**** Hi mate");
            Console.Out.WriteLine(" on origin click");
            PlacesPage page = new PlacesPage();
            await Navigation.PushAsync(page);
        }
    }
}