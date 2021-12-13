using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class FindMyMatchLogic
    {
        public readonly List<Friend> r_FriendsList = new List<Friend>();
        public User m_LoggedInUser;
        private const string k_MessageFailedFetch = "Fetch failed. Please try again.";


        public void FilterByGender(User.eGender i_GenderToFilter)
        {
            foreach(User friend in m_LoggedInUser.Friends)
            {
                if(friend.Gender == i_GenderToFilter)
                {
                    Friend matchFriend = new Friend(friend);
                    r_FriendsList.Add(matchFriend);
                }
            }
        }

        public List<Friend> FilterMyMatch(int i_FromAge, int i_ToAge, User.eGender i_GenderToFilter)
        {
            FilterByGender(i_GenderToFilter);
            filterByAge(i_FromAge, i_ToAge);
            filterByRelationshipStatus();

            return r_FriendsList;
        }

        private void filterByRelationshipStatus()
        {
            try
            {
                foreach(Friend friend in r_FriendsList)
                {
                    if(friend.FriendUser.RelationshipStatus != User.eRelationshipStatus.Single
                       && friend.FriendUser.RelationshipStatus != User.eRelationshipStatus.None)
                    {
                        r_FriendsList.Remove(friend);
                    }
                }
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        public User FindMyFan()
        {
            Friend fan = r_FriendsList[0];

            updateLikesPerFriend();
            try
            {
                foreach(Friend friend in r_FriendsList)
                {
                    if(friend.NumOfLikes > fan.NumOfLikes)
                    {
                        fan = friend;
                    }
                }
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }

            return fan.FriendUser;
        }

        private void updateLikesPerFriend()
        {
            try
            {
                foreach(Post postOfUser in m_LoggedInUser.Posts)
                {
                    foreach(User friend in postOfUser.LikedBy)
                    {
                        r_FriendsList.Find(i_FriendUser => i_FriendUser.FriendUser.Email == friend.Email).NumOfLikes++;
                    }
                }
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }

        private void filterByAge(int i_FromAge, int i_ToAge)
        {
            int theYearToday = int.Parse(DateTime.Now.Date.Year.ToString());

            try
            {
                foreach(Friend friend in r_FriendsList)
                {
                    string friendYearOfBirth = friend.FriendUser.Birthday.Substring(6, 4);
                    int friendYearOfBirthNumber = int.Parse(friendYearOfBirth);
                    int friendAge = theYearToday - friendYearOfBirthNumber;

                    if(friendAge < i_FromAge || friendAge > i_ToAge)
                    {
                        r_FriendsList.Remove(friend);
                        if(r_FriendsList.Count == 0)

                        {
                            break;
                        }
                    }
                }
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }
        }
    }
}