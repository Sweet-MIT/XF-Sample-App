///
/// Copyright(c) Sweet MIT.All rights reserved.
using System;
using XF_Sample_App.IViewModel;

namespace XF_Sample_App.ViewModel
{
    public class WebViewModel : BaseViewModel, IWebViewModel
    {
        private String _siteURL;
        public String SiteURL
        {
            get { return _siteURL; }
            set {
                _siteURL = value;
                OnPropertyChanged(nameof(SiteURL));
            }
        }

        public WebViewModel()
        {
            SiteURL = "http://www.sweetmit.com";
        }
    }
}
