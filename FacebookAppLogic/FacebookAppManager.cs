using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public sealed class FacebookAppManager
    {
        public User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private const string k_MessageFailedFetch = "Fetch failed. Please try again.";
        private const string k_MessageNoData = "No Data to retrieve";
        private const int k_RangeDaysUpcomingBirthdays = 3;
        private static FacebookAppManager s_Instance = null;
        private static readonly object sr_FacebookAppManagerLock = new object();

        private FacebookAppManager()
        {

        }

        public static FacebookAppManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_FacebookAppManagerLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookAppManager();
                        }
                    }
                }

                return s_Instance;
            }
        }
        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
            set
            {
                m_LoggedInUser = value;
            }
        }
        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
            set
            {
                m_LoginResult = value;
            }
        }

        public string FetchPicture()
        {
            return LoggedInUser.PictureNormalURL;
        }

        public void UserLogin()
        {
            m_LoginResult = FacebookService.Login(
                "863872147654112",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos");

            m_LoginResult = FacebookWrapper.FacebookService.Connect("EAAMRrZBhZBBeABAAf3mGAZBSZAmq4wLITXmbz0XwHZAZCKu9IWUE1kk185K9xD2br3S8ZBvPMPqFrM7TZAGFETvMVZC1sy9cBpup8pdgiOuPiG59G2dZCIBbUl3nrIXaWQgJjjlo2wk2vmkqYptL8cxw5OprMkh3b1VpJ7ZCyj2SVhQZBT3XAmc7W0NDZBoTQkv8dj0Y3P6ZBPGdeVxWr14fkyABaG");
            //m_LoginResult = FacebookWrapper.FacebookService.Connect(
            //"EAAMRrZBhZBBeABAAf3mGAZBSZAmq4wLITXmbz0XwHZAZCKu9IWUE1kk185K9xD2br3S8ZBvPMPqFrM7TZAGFETvMVZC1sy9cBpup8pdgiOuPiG59G2dZCIBbUl3nrIXaWQgJjjlo2wk2vmkqYptL8cxw5OprMkh3b1VpJ7ZCyj2SVhQZBT3XAmc7W0NDZBoTQkv8dj0Y3P6ZBPGdeVxWr14fkyABaG");

            //m_LoginResult = FacebookWrapper.FacebookService.Connect("EAAMRrZBhZBBeABABaCfGQXZC7RvKG5YRsacaNfGZATvFxnQeNKBagzATVmI0o2ROLtIsZCgqnJLXR3T0ZAS0KISGnj5hkLSuEwbrLImFodqmXQsrG4rPXZCZAd10Mj3eGaIsup3wLcsJovRJaZAfZAKSf5BiPZBqqavBeyA2iEsSdKM5xs2STGU31j0wRE0yGFsaURmfgVNFuuW6Dk5y6M9uTGB");
/*            m_LoginResult = FacebookWrapper.FacebookService.Connect(
                "EAAMRrZBhZBBeABACgEZChie2ZCCgvrp8xRABOCI16YVQ59xv4mpauBuZAo701hVcPy8oAvjc56jD4BJesszvVdJZChgGuwOgSfnpwVgLxDDlRz8wHfXKmVPAyMk9RZAHPIpZAEY2Tx04aXsZAPoZCnvBDfxlJqsMFO2XAt3ZCezZCbks8x7VleqCohkG");*/
            m_LoggedInUser = m_LoginResult.LoggedInUser;

           /* if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }*/
        }

        public string FetchUserGender()
        {
            return LoggedInUser.Gender.ToString();
        }

        public void PostAndTag(User i_User, string i_Message)
        {
            LoggedInUser.PostStatus(i_Message, i_TaggedFriendIDs: i_User.Id);
        }

        public string FetchUserName()
        {
            return LoggedInUser.Name;
        }

        public string FetchUserLocation()
        {
            return LoggedInUser.Location.Name;
        }

        public string FetchUserBirthday()
        {
            return LoggedInUser.Birthday;
        }

        public int FetchUserAge()
        {
            int theYearToday = int.Parse(DateTime.Now.Date.Year.ToString());
            string userYearOfBirth = LoggedInUser.Birthday.Substring(6, 4);
            int userYearOfBirthNumber = int.Parse(userYearOfBirth);
            int userAge = theYearToday - userYearOfBirthNumber;

            return userAge;
        }

        public Status PostStatus(string i_UserStatusText)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(i_UserStatusText);

            return postedStatus;
        }

        public List<string> FetchUpcomingBirthdays()
        {
            List<string> friendsList = new List<string>();
            string nextDays;
            int stringCompareResult;

            try
            {
                foreach(User friend in LoggedInUser.Friends)
                {
                    for(int i = 0; i < k_RangeDaysUpcomingBirthdays; i++)
                    {
                        nextDays = DateTime.Now.Date.AddDays(i).ToString("dd/MM");
                        stringCompareResult = string.Compare(nextDays, friend.Birthday.Substring(0, 5));
                        if(stringCompareResult == 0)
                        {
                            friendsList.Add(friend.Name + ' ' + friend.Birthday);
                        }
                    }
                }

                return friendsList;
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public List<User> FetchFriendsList()
        {
            List<User> friendsList = new List<User>();

            try
            {
                foreach(User friend in LoggedInUser.Friends)
                {
                    if(friend.Name != null)
                    {
                        friendsList.Add(friend);
                    }
                }

                return friendsList;
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public List<string> FetchNewsFeed()
        {
            List<string> newsFeed = new List<string>();

            try
            {
                foreach(Post post in m_LoggedInUser.Posts)
                {
                    if(post.Message != null)
                    {
                        newsFeed.Add(post.Message);
                    }
                    else if(post.Caption != null)
                    {
                        newsFeed.Add(post.Caption);
                    }
                    else
                    {
                        newsFeed.Add($"[{post.Type}]");
                    }
                }

                return newsFeed;
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public List<Album> FetchAlbums()
        {
            List<Album> albums = new List<Album>();

            try
            {
                foreach(Album album in m_LoggedInUser.Albums)
                {
                    albums.Add(album);
                }
            }
            catch
            {
                throw new Exception(k_MessageNoData);
            }

            return albums;
        }

        public List<Photo> FetchPictures()
        {
            List<Photo> photoList = new List<Photo>();

            try
            {
                foreach(Album album in m_LoggedInUser.Albums)
                {
                    foreach(Photo photo in album.Photos)
                    {
                        photoList.Add(photo);
                    }
                }
            }
            catch
            {
                throw new Exception(k_MessageNoData);
            }

            return photoList;
        }

        public List<Page> FetchLikedPages()
        {
            List<Page> likedPages = new List<Page>();

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    likedPages.Add(page);
                }
            }
            catch
            {
                throw new Exception(k_MessageNoData);
            }

            return likedPages;
        }

        

        public User FindSelectedFriend(string i_UserFriendName)
        {
            User userFriend = new User();
            try
            {
                foreach(User friend in LoggedInUser.Friends)
                {
                    if(string.Compare(friend.Name, i_UserFriendName) == 0)
                    {
                        userFriend = friend;
                    }
                }
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }

            return userFriend;
        }
    }
}