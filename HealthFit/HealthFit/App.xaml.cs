using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using HealthFit.Database;
using HealthFit.Model;

namespace HealthFit
{
    public partial class App : Application
    {
        static DatabaseHF database;

        public static Accounts CurrentAccount;

        public static DatabaseHF Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseHF(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HealthFitDB.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
