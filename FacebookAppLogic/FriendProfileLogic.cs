using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FriendProfileLogic
    {
        public User friend { get; set; }

        public string FetchPicture()
        {
            return friend.PictureNormalURL;
        }

        public string FetchUserBirthday()
        {
            return friend.Birthday;
        }
        public string FetchUserName()
        {
            return friend.Name;
        }

        public string FetchUserGender()
        {
            return friend.Gender.ToString();
        }

    }
}
