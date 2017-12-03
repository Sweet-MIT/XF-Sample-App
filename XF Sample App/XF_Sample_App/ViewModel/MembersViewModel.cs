///
/// Copyright(c) Sweet MIT.All rights reserved.
using XF_Sample_App.Model;
using XF_Sample_App.IViewModel;
using System.Collections.ObjectModel;

namespace XF_Sample_App.ViewModel
{
    public class MembersViewModel : BaseViewModel, IMembersViewModel
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

        public MembersViewModel()
        {
            Items = new ObservableCollection<Member>
            {
                new Member() {
                    FullName = "Mohamed NOUIRA",
                    Post = "CTO"
                },
                new Member() {
                    FullName = "Amine NOUIRA",
                     Post = "Project Manager"
                }
            };
        }
    }
}
