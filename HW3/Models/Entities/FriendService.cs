using HW4.Models.Abstract_entities;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace HW4.Models.Entities
{
    public class FriendService : IFriendService
    {
        
        public int Id { get; set; }
        public string FriendName { get; set; }
        public string Place { get; set; }
        public int FriendAge { get; set; }

        public List<FriendService> GetFriends()
        {
            string filePath = "friends.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                FriendService[] friends = JsonSerializer.Deserialize<FriendService[]>(jsonString);
                return friends.ToList();
            }
            else
            {
                return new List<FriendService>();
            }
        }

        //public void CreateFriendsFile()
        //{
        //    string filePath = "friends.json";
        //    if (!File.Exists(filePath))
        //    {
        //        List<FriendService> friendList = new List<FriendService>()
        //        {
        //            new FriendService{ FriendId = 1,  FriendName = "Ivan",  Place = "Minsk" },
        //            new FriendService{ FriendId = 2,  FriendName = "Sergey", Place = "Grodno" },
        //            new FriendService{ FriendId = 3,  FriendName = "Maria",  Place = "Gomel" }
        //        };

        //        string jsonString = JsonConvert.SerializeObject(friendList);
        //        File.WriteAllText(filePath, jsonString);
        //    }
        //}
    }
}
