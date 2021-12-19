﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

namespace FacebookAppLogic
{
    public class FindMyMatchLogic
    {
        public readonly List<FriendLogic> r_FriendsList = new List<FriendLogic>();
        private FacebookAppManager m_AppManager = FacebookAppManager.Instance;
        private const string k_MessageFailedFetch = "Fetch failed. Please try again.";
        private static readonly object sr_FacebookAppManagerLock = new object();

        public List<string> FetchMyMatchesInfo()
        {

            List<string> matchesByFormat = new List<string>();

            foreach (FriendLogic friend in r_FriendsList)
            {
                IMyMatchFormat iMatchesFormat = new MyMatchFormatAdapter(friend.Friend);
                matchesByFormat.AddRange(iMatchesFormat.CreateFormattedMatchesList());

            }

            return matchesByFormat;
        }

        public int GetNameIndex(string selected_item, int selectedIndex)
        {

            switch(selected_item[0])
            {
                case '-':
                    return selectedIndex - 3;
                case 'L':
                    return selectedIndex - 2;
                case 'A':
                    return selectedIndex - 1;
                default:
                    return selectedIndex;
            }
        }


        public User FindSelectedFriend(string i_UserFriendName)
        {
            User userFriend = new User();
            i_UserFriendName = i_UserFriendName.Substring(6);
            try
            {
                foreach (FriendLogic friend in r_FriendsList)
                {
                    if (string.Compare(friend.Friend.Name, i_UserFriendName) == 0)
                    {
                        userFriend = friend.Friend;
                    }
                }
            }
            catch
            {
                throw new Exception(k_MessageFailedFetch);
            }

            return userFriend;
        }
        public void UpdateFriendList(List<FriendLogic> i_FriendsList)
        {

            foreach (FriendLogic friend in i_FriendsList)
            {
                r_FriendsList.Add(friend);
            }
        }
        public void FilterByGender(User.eGender i_GenderToFilter)
        {
            foreach(User friend in m_AppManager.LoggedInUser.Friends)
            {
                if(friend.Gender == i_GenderToFilter)
                {
                    FriendLogic matchFriend = new FriendLogic();
                    matchFriend.Friend = friend;
                    r_FriendsList.Add(matchFriend);
                }
            }
        }
        
        public List<FriendLogic> FilterMyMatch(int i_FromAge, int i_ToAge, User.eGender i_GenderToFilter)
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
                foreach(FriendLogic friend in r_FriendsList)
                {
                    if(friend.Friend.RelationshipStatus != User.eRelationshipStatus.Single
                       && friend.Friend.RelationshipStatus != User.eRelationshipStatus.None)
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
            FriendLogic fan=new FriendLogic();
                fan.Friend= r_FriendsList[0].Friend;

            updateLikesPerFriend();
            try
            {
                foreach(FriendLogic friend in r_FriendsList)
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
       
            return fan.Friend;
        }

        private void updateLikesPerFriend()
        {
            try
            {
                foreach(Post postOfUser in m_AppManager.m_LoggedInUser.Posts)
                {
                    foreach(User friend in postOfUser.LikedBy)
                    {
                        r_FriendsList.Find(i_FriendUser => i_FriendUser.Friend.Email == friend.Email).NumOfLikes++;
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
                foreach(FriendLogic friend in r_FriendsList)
                {
                    string friendYearOfBirth = friend.Friend.Birthday.Substring(6, 4);
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