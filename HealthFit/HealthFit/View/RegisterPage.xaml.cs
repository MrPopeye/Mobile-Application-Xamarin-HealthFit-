using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HealthFit.Model;

namespace HealthFit.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fnameEntry.Text) || string.IsNullOrEmpty(lnameEntry.Text))
            {
                await DisplayAlert("Eroare", "Nu ai completat toate câmpurile cu *.", "Ok");
            } else if (string.IsNullOrWhiteSpace(fnameEntry.Text) || string.IsNullOrWhiteSpace(lnameEntry.Text))
            {
                await DisplayAlert("Eroare", "Nu ai completat toate câmpurile cu *.", "Ok");
            } else
            {
                await App.Database.SaveAccountAsync(new Accounts
                {
                    NameF = fnameEntry.Text,
                    NameP = lnameEntry.Text,
                    BDate = bdayEntry.Date
                });

                await DisplayAlert("Înregistrare", "Profilul a fost creat cu succes!", "Ok");

                fnameEntry.Text = string.Empty;
                lnameEntry.Text = string.Empty;
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}