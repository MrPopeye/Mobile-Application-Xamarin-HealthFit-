using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthFit.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProfilePageView : ContentPage
    {
        public EditProfilePageView()
        {
            InitializeComponent();
        }
        private async void NumeFamilieButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numefamilieEntry.Text) || string.IsNullOrWhiteSpace(numefamilieEntry.Text))
            {
                await DisplayAlert("Eroare", "Nu ai introdus numele de familie.", "Ok");
            }
            else
            {
                UpdateAccountNameP();
            }
        }
        private async void PrenumeButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prenumeEntry.Text) || string.IsNullOrWhiteSpace(prenumeEntry.Text))
            {
                await DisplayAlert("Eroare", "Nu ai introdus prenumele.", "Ok");
            }
            else
            {
                UpdateAccountNameF();
            }
        }
        private async void DeleteAccButton_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Delete profile", "Ești sigur că dorești să ștergi profilul actual? Nu-l vei mai putea recupera!", "Ok", "Cancel");
            if (result)
            {
                await App.Database.DeleteAccountAsync(App.CurrentAccount);
                await Navigation.PushAsync(new MainPage());
            }
        }
        private async void BdateButton_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Edit profile", "Ești sigur că dorești să modifici data de naștere?", "Ok", "Cancel");
            if (result)
            {
                App.CurrentAccount.BDate = bday.Date;
                await App.Database.UpdateAccountAsync(App.CurrentAccount);
                await Navigation.PushAsync(new MainPage());
            }
        }
        async void UpdateAccountNameP()
        {
            App.CurrentAccount.NameP = numefamilieEntry.Text;
            await App.Database.UpdateAccountAsync(App.CurrentAccount);
            await DisplayAlert("Edit Profile", "Modificarea a fost salvată, ai fost redirecționat la pagina principală.", "Ok");
            await Navigation.PushAsync(new MainPage());
        }
        async void UpdateAccountNameF()
        {
            App.CurrentAccount.NameF = prenumeEntry.Text;
            await App.Database.UpdateAccountAsync(App.CurrentAccount);
            await DisplayAlert("Edit Profile", "Modificarea a fost salvată, ai fost redirecționat la pagina principală.", "Ok");
            await Navigation.PushAsync(new MainPage());
        }
    }
}