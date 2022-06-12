using OOP2V92022.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OOP2V92022.Service
{
    public interface IFriendService
    {
        void DeleteFriend(string ime);
        Friend GetByFirstName(string ime);
        Task<IEnumerable<Friend>> GetFriends();
        void SaveFriend(Friend friend);
    }
}