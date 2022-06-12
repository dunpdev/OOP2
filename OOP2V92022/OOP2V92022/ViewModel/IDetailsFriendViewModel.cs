using OOP2V92022.Model;
using Prism.Commands;

namespace OOP2V92022.ViewModel
{
    public interface IDetailsFriendViewModel
    {
        Friend Friend { get; set; }
        DelegateCommand SaveCommand { get; set; }
    }
}