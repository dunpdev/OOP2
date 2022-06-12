using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V92022.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public IListFriendsViewModel ListFriends { get; set; }
        public IDetailsFriendViewModel DetailsFriend { get; set; }
        public MainViewModel(IListFriendsViewModel listFriends
            ,IDetailsFriendViewModel detailsFriend)
        {
            ListFriends = listFriends;
            DetailsFriend = detailsFriend;
        }
        public async Task Load()
        {
            await ListFriends.Load();
        }

    }
}
