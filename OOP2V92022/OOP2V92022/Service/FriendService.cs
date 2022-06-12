using OOP2V92022.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP2V92022.Service
{
    public class FriendService : IFriendService
    {
        private List<Friend> friends = new List<Friend>
        {
          new Friend{Ime="Elma",Prezime="Mujovic",Telefon="063333",Email="e@gmail.com"},
          new Friend{Ime="Edina",Prezime="Kucevic",Telefon="063222",Email="ed@gmail.com"},
          new Friend{Ime="Tarik",Prezime="Ibrahimovic",Telefon="06555",Email="t@gmail.com"}
        };
        // CRUD

        // Save
        public void SaveFriend(Friend friend)
        {
            var ff = GetByFirstName(friend.Ime);
            if (ff == null)
            {
                friends.Add(friend);
            }
            else
            {
                ff.Prezime = friend.Prezime;
                ff.Telefon = friend.Telefon;
                ff.Email = friend.Email;
            }
        }
        // Read
        public async Task<IEnumerable<Friend>> GetFriends()
        {
            await Task.Run(() =>
           {
               Thread.Sleep(3000);
           }); // Ilustracija kasnjenja baze podataka
            return friends;
        }
        public Friend GetByFirstName(string ime)
        {
            var friend = friends.SingleOrDefault(f => f.Ime == ime);
            return friend;
        }
        // Delete
        public void DeleteFriend(string ime)
        {
            var friend = GetByFirstName(ime);
            if (friend != null)
                friends.Remove(friend);
        }
    }
}
