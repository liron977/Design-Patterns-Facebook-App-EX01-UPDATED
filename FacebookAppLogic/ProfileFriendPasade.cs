using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ProfileFriendPasade
    {
        public FriendProfileLogic friend = new FriendProfileLogic();
        public FriendProfileLogic Friend
        {
            get
            {
                return friend;
            }
            set
            {
                friend = value;
            }
        }
        public string GetPicture()
        {
            return friend.FetchPicture();
        }

        public int GetAge()
        {
            return friend.FetchUserAge();
        }

        public string GetBirthday()
        {
            return friend.FetchUserBirthday();
        }

        public string GetUserName()
        {
            return friend.FetchUserName();
        }

        public string GetGender()
        {
            return friend.FetchUserGender();
        }

        public string GetLocation()
        {
            return friend.FetchLocation();
        }

        public List<Photo> GetPictures()
        {
            return friend.FetchPictures();
        }

        public List<Page> GetLikedPages()
        {
            return friend.FetchLikedPages();

        }



    }
}
