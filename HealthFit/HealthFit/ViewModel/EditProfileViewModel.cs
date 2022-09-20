using System;

namespace HealthFit.ViewModel
{
    public class EditProfileViewModel : BaseViewModel
    {
        private string nameP;
        private string nameF;
        public DateTime bDate;

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
        public DateTime BDate
        {
            get => bDate;
            set => SetProperty(ref bDate, value);
        }
        public EditProfileViewModel()
        {
            NameP = App.CurrentAccount.NameP;
            NameF = App.CurrentAccount.NameF;
            BDate = App.CurrentAccount.BDate;
        }
    }
}
