using OOP2V92022.Model;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace OOP2V92022.ViewModel
{
    public interface IListFriendsViewModel
    {
        ObservableCollection<Friend> Friends { get; set; }
        Friend SelectedFriend { get; set; }

        Task Load();
    }
}