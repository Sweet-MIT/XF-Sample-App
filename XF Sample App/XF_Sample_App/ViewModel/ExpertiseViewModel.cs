///
/// Copyright(c) Sweet MIT.All rights reserved.
using System;
using XF_Sample_App.IViewModel;

namespace XF_Sample_App.ViewModel
{
    public class ExpertiseViewModel : BaseViewModel, IExpertiseViewModel
    {
        private String _expertiseText;
        public String ExpertiseText
        {
            get { return _expertiseText; }
            set
            {
                _expertiseText = value;
                OnPropertyChanged(nameof(ExpertiseText));
            }
        }

        public ExpertiseViewModel()
        {
            ExpertiseText = "Sweet MIT has been developed for programming's geeks to start their patience, read, share and like blogs, videos ! you can use the application from our site : www.sweetmit.com";
        }
    }
}
