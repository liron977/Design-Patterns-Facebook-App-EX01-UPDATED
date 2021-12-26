using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;


namespace FacebookAppLogic
{
    public class FriendLogic
    {
        public User Friend { get; set; }

        private const string k_MessageNoData = "No Data to retrieve";

        public int NumOfLikes { get; set; }

        public FriendLogic()
        {
            NumOfLikes = 0;
        }

        public string FetchPicture()
        {
            return Friend.PictureNormalURL;
        }

        public string FetchUserBirthday()
        {
            return Friend.Birthday;
        }

        public string FetchUserName()
        {
            return Friend.Name;
        }

        public string FetchUserGender()
        {
            return Friend.Gender.ToString();
        }

        public int FetchUserAge()
        {
            int theYearToday = int.Parse(DateTime.Now.Date.Year.ToString());
            string userYearOfBirth = Friend.Birthday.Substring(6, 4);
            int userYearOfBirthNumber = int.Parse(userYearOfBirth);
            int userAge = theYearToday - userYearOfBirthNumber;

            return userAge;
        }

        public string FetchLocation()
        {
            return Friend.Location.Name;
        }

        public List<Photo> FetchPictures()
        {
            List<Photo> photoList = new List<Photo>();

            try
            {
                foreach(Album album in Friend.Albums)
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
                foreach(Page page in Friend.LikedPages)
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
    }
}