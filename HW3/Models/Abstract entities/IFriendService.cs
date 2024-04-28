using HW4.Models.Entities;
using System.Security.Cryptography;

namespace HW4.Models.Abstract_entities
{
    public interface IFriendService
    {
        bool Create(FriendService friend);
        List<FriendService> GetFriends();
        void RemoveFriend(int friendId);
    }
}
