///
/// Copyright(c) Sweet MIT.All rights reserved.
using Xamarin.Forms;
using XF_Sample_App.IViewModel;

namespace XF_Sample_App.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DependencyService.Register<IHomeViewModel, HomeViewModel>();
            DependencyService.Register<IManagersViewModel, ManagersViewModel>();
            DependencyService.Register<IMembersViewModel, MembersViewModel>();
            DependencyService.Register<IExpertiseViewModel, ExpertiseViewModel>();
            DependencyService.Register<IAboutViewModel, AboutViewModel>();
            DependencyService.Register<IContactViewModel, ContactViewModel>();
            DependencyService.Register<IWebViewModel, WebViewModel>();
        }

        public IHomeViewModel Home
        {
            get
            {
                return DependencyService.Get<IHomeViewModel>();
            }
        }

        public IManagersViewModel Managers
        {
            get
            {
                return DependencyService.Get<IManagersViewModel>();
            }
        }

        public IMembersViewModel Members
        {
            get
            {
                return DependencyService.Get<IMembersViewModel>();
            }
        }

        public IExpertiseViewModel Expertise
        {
            get
            {
                return DependencyService.Get<IExpertiseViewModel>();
            }
        }

        public IAboutViewModel About
        {
            get
            {
                return DependencyService.Get<IAboutViewModel>();
            }
        }

        public IContactViewModel Contact
        {
            get
            {
                return DependencyService.Get<IContactViewModel>();
            }
        }

        public IWebViewModel Web
        {
            get
            {
                return DependencyService.Get<IWebViewModel>();
            }
        }
    }
}
