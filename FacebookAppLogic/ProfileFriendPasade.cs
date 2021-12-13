using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
