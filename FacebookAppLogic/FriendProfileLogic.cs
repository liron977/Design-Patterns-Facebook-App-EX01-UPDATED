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
        private const string k_MessageNoData = "No Data to retrieve";

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

        public int FetchUserAge()
        {
            int theYearToday = int.Parse(DateTime.Now.Date.Year.ToString());
            string userYearOfBirth = friend.Birthday.Substring(6, 4);
            int userYearOfBirthNumber = int.Parse(userYearOfBirth);
            int userAge = theYearToday - userYearOfBirthNumber;

            return userAge;
        }

        public string FetchLocation()
        {
            return friend.Location.Name;
        }

        public List<Photo> FetchPictures()
        {
            List<Photo> photoList = new List<Photo>();

            try
            {
                foreach (Album album in friend.Albums)
                {
                    foreach (Photo photo in album.Photos)
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
                foreach (Page page in friend.LikedPages)
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
