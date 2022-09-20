using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HealthFit.View.WorkoutExView;

namespace HealthFit.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        #region buttons
        private void DayOneButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DayOne());
        }
        private void DayTwoButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DayTwo());
        }
        private void DayThreeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DayThree());
        }
        private void DayFourButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DayFour());
        }
        private void DayFiveButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DayFive());
        }
        private void DaySixButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DaySix());
        }
        private void DaySevenButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DaySeven());
        }
        #endregion

        #region TapGestures

        private void TapGestureRecognizerInfo_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InformationPage());
        }
        private void TapGestureListFood_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodListPageView());
        }
        private void TapGestureMedicMap_Tapped(object sender, EventArgs e)
        {
             Navigation.PushAsync(new MedicMap());
        }
        private void TapGestureEditProfile_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditProfilePageView());
        }
        #endregion
    }
}