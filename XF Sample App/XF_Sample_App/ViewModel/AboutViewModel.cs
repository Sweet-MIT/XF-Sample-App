///
/// Copyright(c) Sweet MIT.All rights reserved.
using System;
using XF_Sample_App.IViewModel;

namespace XF_Sample_App.ViewModel
{
    public class AboutViewModel : BaseViewModel, IAboutViewModel
    {
        private String _about;
        public String About
        {
            get { return _about; }
            set
            {
                _about = value;
                OnPropertyChanged(nameof(About));
            }
        }

        public AboutViewModel()
        {
            About = "Sweet MIT has been developed for programming's geeks to start their patience, read, share and like blogs, videos ! you can use the application from our site : www.sweetmit.com";
        }
    }
}
