using HW4.Models.Entities;

namespace HW4.Models.Abstract_entities
{
    public interface IFriendService
    {
        public List<Friend> GetFriends();
        public void CreateFriendsFile();
    }
}
