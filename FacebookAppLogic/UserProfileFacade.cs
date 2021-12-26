using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserProfileFacade
    {
        private readonly FacebookAppManager r_AppManager;

        public UserProfileFacade()
        {
            r_AppManager = FacebookAppManager.Instance;
        }

        public string GetPicture()
        {
            return r_AppManager.FetchPicture();
        }

        public List<string> GetNewsFeed()
        {
            return r_AppManager.FetchNewsFeed();
        }

        public List<User> GetFriends()
        {
            return r_AppManager.FetchFriendsList();
        }

        public List<string> GetUpcomingBirthdays()
        {
            return r_AppManager.FetchUpcomingBirthdays();
        }

        public List<Album> GetAlbums()
        {
            return r_AppManager.FetchAlbums();
        }

        public Status PostStatus(string i_UserStatusText)
        {
            return r_AppManager.PostStatus(i_UserStatusText);
        }

        public void PostAndTag(User i_User, string i_Message)
        {
            r_AppManager.PostAndTag(i_User, i_Message);
        }

        public string GetUserName()
        {
            return r_AppManager.FetchUserName();
        }
    }
}