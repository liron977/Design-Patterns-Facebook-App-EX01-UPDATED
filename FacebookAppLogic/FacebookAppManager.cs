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
        private static FacebookAppManager s_Instance;
        private static readonly object sr_FacebookAppManagerLock = new object();

        private FacebookAppManager()
        {
        }

        public static FacebookAppManager Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_FacebookAppManagerLock)
                    {
                        if(s_Instance == null)
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

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception(k_MessageNoData);
            }
        }


        public void PostAndTag(User i_User, string i_Message)
        {
            LoggedInUser.PostStatus(i_Message, i_TaggedFriendIDs: i_User.Id);
        }

        public string FetchUserName()
        {
            return LoggedInUser.Name;
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
    }
}