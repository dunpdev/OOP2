using OOP2V92022.Model;
using OOP2V92022.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using OOP2V92022.Event;

namespace OOP2V92022.ViewModel
{
    public class ListFriendsViewModel : BaseViewModel, IListFriendsViewModel
    {
        private Friend selectedFriend;
        private readonly IFriendService service;
        private readonly IEventAggregator eventAggregator;

        public Friend SelectedFriend
        {
            get { return selectedFriend; }
            set
            {
                selectedFriend = value;
                OnPropertyChanged();
                if (selectedFriend != null)
                {
                    // Obavesti DetailViewModel da je doslo do promene izbora
                    eventAggregator.GetEvent<OpenFriendDetailsEvent>().Publish(selectedFriend.Ime);
                }
            }
        }
        public ObservableCollection<Friend> Friends { get; set; }
        public ListFriendsViewModel(IFriendService service,
            IEventAggregator eventAggregator)
        {
            this.service = service;
            this.eventAggregator = eventAggregator;
            Friends = new ObservableCollection<Friend>();
            SelectedFriend = new Friend();
        }

        public async Task Load()
        {
            var listFriends = await service.GetFriends();
            Friends.Clear();
            foreach (var friend in listFriends)
            {
                Friends.Add(friend);
            }
        }
    }
}
