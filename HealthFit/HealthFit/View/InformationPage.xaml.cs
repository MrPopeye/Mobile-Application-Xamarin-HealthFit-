using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthFit.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationPage : ContentPage
    {
        public InformationPage()
        {
            InitializeComponent();
        }
        private async void InaltimeButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inaltimeEntry.Text) || string.IsNullOrWhiteSpace(inaltimeEntry.Text))
            {
                await DisplayAlert("Eroare", "Nu ai introdus înalțimea.", "Ok");
            }
            else
            {
                UpdateAccountHeight();
            }
        }
        private async void GreutateButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(greutateEntry.Text) || string.IsNullOrWhiteSpace(greutateEntry.Text))
            {
                await DisplayAlert("Eroare", "Nu ai introdus greutatea.", "Ok");
            }
            else
            {
                UpdateAccountWeight();
            }
        }
        async void UpdateAccountHeight()
        {
            App.CurrentAccount.PersonHeight = inaltimeEntry.Text;
            await App.Database.UpdateAccountAsync(App.CurrentAccount);
            await DisplayAlert("Edit", "Modificarea a fost salvată, ai fost redirecționat la pagina principală.", "Ok");
            await Navigation.PushAsync(new MainPage());
        }
        async void UpdateAccountWeight()
        {
            App.CurrentAccount.PersonWeight = greutateEntry.Text;
            await App.Database.UpdateAccountAsync(App.CurrentAccount);
            await DisplayAlert("Edit", "Modificarea a fost salvată, ai fost redirecționat la pagina principală.", "Ok");
            await Navigation.PushAsync(new MainPage());
        }
    }
}