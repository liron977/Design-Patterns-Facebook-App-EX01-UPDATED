using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class Friend
    {
        public User FriendUser { get; set; }

        public int NumOfLikes { get; set; }

        public Friend(User i_FriendUser)
        {
            FriendUser = i_FriendUser;
            NumOfLikes = 0;
        }
    }
}