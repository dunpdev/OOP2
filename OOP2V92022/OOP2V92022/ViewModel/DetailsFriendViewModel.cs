using OOP2V92022.Event;
using OOP2V92022.Model;
using OOP2V92022.Service;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V92022.ViewModel
{
    public class DetailsFriendViewModel : BaseViewModel, IDetailsFriendViewModel
    {
        private Friend friend;
        private DelegateCommand saveCommand;

        public DelegateCommand SaveCommand
        {
            get { return saveCommand; }
            set { saveCommand = value; }
        }


        public Friend Friend
        {
            get { return friend; }
            set
            {
                friend = value;
                OnPropertyChanged();
                if (!string.IsNullOrEmpty(friend.Ime))
                    SaveCommand.RaiseCanExecuteChanged();
            }
        }

        private readonly IEventAggregator eventAggregator;
        private readonly IFriendService friendService;

        public DetailsFriendViewModel(IEventAggregator eventAggregator,
            IFriendService friendService)
        {
            this.eventAggregator = eventAggregator;
            this.friendService = friendService;
            Friend = new Friend();
            SaveCommand = new DelegateCommand(SaveData, CanSave);
            eventAggregator.GetEvent<OpenFriendDetailsEvent>().Subscribe(GetData);
        }

        private bool CanSave()
        {
            if (!string.IsNullOrEmpty(Friend.Ime))
                return true;
            return false;
        }

        private void SaveData()
        {
            friendService.SaveFriend(Friend);
        }

        private void GetData(string ime)
        {
            Friend = friendService.GetByFirstName(ime);
        }
    }
}
