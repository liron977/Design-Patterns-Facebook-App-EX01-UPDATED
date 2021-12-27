using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MyMatchFormatAdapter : IMyMatchFormat
    {
        private readonly User r_FriendUser;
        private readonly int r_CurrentYear;

        public MyMatchFormatAdapter(User i_FriendUser)
        {
            r_FriendUser = i_FriendUser;
            r_CurrentYear = int.Parse(DateTime.Now.Year.ToString());
        }

        public List<string> CreateFormattedMatchesList()
        {
            try
            {
                List<string> matchesInfo = new List<string>();
                int yearOfBirth = int.Parse(r_FriendUser.Birthday.Substring(6, 4));
                string friendLocation = r_FriendUser.Location.ToString();
                friendLocation = friendLocation.Replace("(location: )", "");
                matchesInfo.Add(string.Format($@"Name: {r_FriendUser.Name}"));
                matchesInfo.Add(string.Format($@"Age: {r_CurrentYear - yearOfBirth}"));
                matchesInfo.Add(string.Format($@"Location: {friendLocation}"));

                matchesInfo.Add(drawLine());

                return matchesInfo;
            }
            catch(Exception ex)
            {
                throw new Exception("Error: Couldn't fetch information");
            }
        }

        private string drawLine()
        {
            return @"-------------------------------------------------------------------------";
        }
    }
}