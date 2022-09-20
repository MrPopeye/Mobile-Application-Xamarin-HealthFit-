using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HealthFit.ViewModel;

namespace HealthFit.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodListPageView : ContentPage
    {
        public FoodListPageView()
        {
            InitializeComponent();
        }
        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var container = BindingContext as FoodListPageViewModel;
            myFoodList.BeginRefresh();
            if(string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                myFoodList.ItemsSource = container.FoodsList;
            }
            else
            {
                myFoodList.ItemsSource = container.FoodsList.Where(i => i.FoodName.Contains(e.NewTextValue));
            }
            myFoodList.EndRefresh();
        }
    }
}