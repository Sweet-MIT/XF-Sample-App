using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XF_Sample_App.Views;

namespace XF_Sample_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            NavigationPage navigationPage = new NavigationPage(new HomeView());
            navigationPage.BarBackgroundColor = Color.FromHex("#7E1335");
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
