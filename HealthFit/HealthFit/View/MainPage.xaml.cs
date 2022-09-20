using System;
using Xamarin.Forms;
using HealthFit.View;

namespace HealthFit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        private void CreateProfileTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
        private async void SelectProfileTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.CurrentAccount = await App.Database.GetAccountByIdAsync((int)((TappedEventArgs)e).Parameter);
            await Navigation.PushAsync(new HomePage());
        }
        private void DistribuieButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DistribuiePage());
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetAccountsAsync();
        }
    }
}
