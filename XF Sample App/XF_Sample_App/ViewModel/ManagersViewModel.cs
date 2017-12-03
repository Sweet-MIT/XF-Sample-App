///
/// Copyright(c) Sweet MIT.All rights reserved.
using XF_Sample_App.Model;
using XF_Sample_App.IViewModel;
using System.Collections.ObjectModel;

namespace XF_Sample_App.ViewModel
{
    public class ManagersViewModel : BaseViewModel, IManagersViewModel
    {

        private ObservableCollection<Member> _items;
        public ObservableCollection<Member> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }
        
        public ManagersViewModel()
        {
            Items = new ObservableCollection<Member>
            {
                new Member() {
                    FullName = "Mohamed Ali NOUIRA",
                    Post = "CEO"
                },
                new Member() {
                    FullName = "Rabiaa NOUIRA",
                     Post = "Advisor"
                }
            };
        }
    }
}
