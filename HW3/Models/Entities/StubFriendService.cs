using HW4.Models.Abstract_entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HW4.Models.Entities
{
    public class StubFriendService : IFriendService
    {
        public List<FriendService> GetFriends()
        {
            return new List<FriendService>();
        }

        //public void CreateFriendsFile()
        //{
        //    return ;
        //}
    }
}
