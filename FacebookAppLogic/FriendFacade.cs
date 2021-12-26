
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FriendFacade
    {
        public FriendLogic m_FriendLogic = new FriendLogic();
        public FriendLogic FriendLogic
        {
            get
            {
                return m_FriendLogic;
            }
            set
            {
                m_FriendLogic = value;
            }
        }

        public string GetPicture()
        {
            return m_FriendLogic.FetchPicture();
        }

        public int GetAge()
        {
            return m_FriendLogic.FetchUserAge();
        }

        public string GetBirthday()
        {
            return m_FriendLogic.FetchUserBirthday();
        }

        public string GetUserName()
        {
            return m_FriendLogic.FetchUserName();
        }

        public string GetGender()
        {
            return m_FriendLogic.FetchUserGender();
        }

        public string GetLocation()
        {
            return m_FriendLogic.FetchLocation();
        }

        public List<Photo> GetPictures()
        {
            return m_FriendLogic.FetchPictures();
        }

        public List<Page> GetLikedPages()
        {
            return m_FriendLogic.FetchLikedPages();
        }
    }
}