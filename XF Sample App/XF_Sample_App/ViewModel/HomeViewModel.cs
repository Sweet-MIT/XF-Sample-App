///
/// Copyright(c) Sweet MIT.All rights reserved.
using System;
using Xamarin.Forms;
using XF_Sample_App.Views;
using System.Windows.Input;
using XF_Sample_App.IViewModel;

namespace XF_Sample_App.ViewModel
{
    public class HomeViewModel : BaseViewModel, IHomeViewModel
    {
        private String _summary;

        public String Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        public ICommand OnGridViewTappedCommand { get; set; }

        public HomeViewModel()
        {
            this.Summary = "Sample App";
            OnGridViewTappedCommand = new Command(OnGridViewTapped);
        }

        private async void OnGridViewTapped(object tag)
        {
            switch (tag)
            {
                case "0":
                    await App.Current.MainPage.Navigation.PushAsync(new AboutView());
                    break;
                case "1":
                    await App.Current.MainPage.Navigation.PushAsync(new ManagersView());
                    break;
                case "2":
                    await App.Current.MainPage.Navigation.PushAsync(new MembersView());
                    break;
                case "3":
                    await App.Current.MainPage.Navigation.PushAsync(new ExpertiseView());
                    break;
                case "4":
                    await App.Current.MainPage.Navigation.PushAsync(new ContactView());
                    break;
                case "5":
                    await App.Current.MainPage.Navigation.PushAsync(new WebSiteView());
                    break;
                default:
                    break;
            }
        }
    }
}
