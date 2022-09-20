using System;
using System.Collections.Generic;
using System.Text;

namespace HealthFit.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        private string nameP;
        private string nameF;
        private string personWeight;
        private string personHeight;
        public string NameP
        {
            get => nameP;
            set => SetProperty(ref nameP, value);
        }
        public string NameF
        {
            get => nameF;
            set => SetProperty(ref nameF, value);
        }
        public string PersonWeight
        {
            get => personWeight;
            set => SetProperty(ref personWeight, value);
        }
        public string PersonHeight
        {
            get => personHeight;
            set => SetProperty(ref personHeight, value);
        }
        public HomePageViewModel()
        {
            NameP = App.CurrentAccount.NameP;
            NameF = App.CurrentAccount.NameF;
            PersonWeight = App.CurrentAccount.PersonWeight;
            PersonHeight = App.CurrentAccount.PersonHeight;
            Title = "Home Page";
        }
    }
}
