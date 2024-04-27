using HW4.Models.Entities;

namespace HW4.Models.Abstract_entities
{
    public interface IFriendService
    {
        public List<FriendService> GetFriends();
        //public void CreateFriendsFile();
    }
}
